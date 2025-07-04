CREATE OR REPLACE PROCEDURE Get_Recommendations (
    p_user_id IN VARCHAR2,
    p_result OUT SYS_REFCURSOR
) AS
BEGIN
    OPEN p_result FOR
    WITH 
    -- Content-Based
    Content AS (
        SELECT DISTINCT m.movie_id, m.title, 0.4 AS weight
        FROM dbs_Movies m
        JOIN dbs_Movie_Genre mg ON m.movie_id = mg.movie_id
        JOIN dbs_Movie_Language ml ON m.movie_id = ml.movie_id
        WHERE (
            mg.genre_name IN (
                SELECT mg.genre_name
                FROM dbs_Recently_Watched rw
                JOIN dbs_Movie_Genre mg ON rw.movie_id = mg.movie_id
                WHERE rw.user_id = p_user_id
            )
            OR ml.lang_id IN (
                SELECT ml.lang_id
                FROM dbs_Recently_Watched rw
                JOIN dbs_Movie_Language ml ON rw.movie_id = ml.movie_id
                WHERE rw.user_id = p_user_id
            )
        )
        AND m.movie_id NOT IN (
            SELECT movie_id FROM dbs_Recently_Watched WHERE user_id = p_user_id
        )
    ),

    -- Collaborative Filtering
    Collaborative AS (
        SELECT DISTINCT m.movie_id, m.title, 0.3 AS weight
        FROM dbs_Recently_Watched rw1
        JOIN dbs_Recently_Watched rw2 ON rw1.movie_id = rw2.movie_id AND rw1.user_id <> rw2.user_id
        JOIN dbs_Movies m ON rw2.movie_id = m.movie_id
        WHERE rw1.user_id = p_user_id
        AND rw2.movie_id NOT IN (
            SELECT movie_id FROM dbs_Recently_Watched WHERE user_id = p_user_id
        )
    ),

    -- Trending Among Similar Users
    Trending AS (
        SELECT rw.movie_id, m.title, 0.15 AS weight
        FROM dbs_Recently_Watched rw
        JOIN dbs_Movies m ON rw.movie_id = m.movie_id
        WHERE rw.user_id IN (
            SELECT DISTINCT rw2.user_id
            FROM dbs_Recently_Watched rw1
            JOIN dbs_Recently_Watched rw2 ON rw1.movie_id = rw2.movie_id
            WHERE rw1.user_id = p_user_id AND rw1.user_id <> rw2.user_id
        )
        AND rw.movie_id NOT IN (
            SELECT movie_id FROM dbs_Recently_Watched WHERE user_id = p_user_id
        )
        GROUP BY rw.movie_id, m.title
    ),

    -- Top Rated in Watched Genres
    TopRated AS (
        SELECT m.movie_id, m.title, 0.15 AS weight
        FROM dbs_Movies m
        JOIN dbs_Rating r ON m.movie_id = r.movie_id
        JOIN dbs_Movie_Genre mg ON m.movie_id = mg.movie_id
        WHERE mg.genre_name IN (
            SELECT mg.genre_name
            FROM dbs_Recently_Watched rw
            JOIN dbs_Movie_Genre mg ON rw.movie_id = mg.movie_id
            WHERE rw.user_id = p_user_id
        )
        AND m.movie_id NOT IN (
            SELECT movie_id FROM dbs_Recently_Watched WHERE user_id = p_user_id
        )
        GROUP BY m.movie_id, m.title
        HAVING AVG(r.rating) > 4
    ),

    Combined AS (
        SELECT * FROM Content
        UNION ALL
        SELECT * FROM Collaborative
        UNION ALL
        SELECT * FROM Trending
        UNION ALL
        SELECT * FROM TopRated
    )

    SELECT movie_id, title, SUM(weight) AS final_score
    FROM Combined
    GROUP BY movie_id, title
    ORDER BY final_score DESC
END;
/