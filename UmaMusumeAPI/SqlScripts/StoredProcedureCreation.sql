-- 
-- Set character set the client will use to send SQL statements to the server
--
SET NAMES 'utf8mb4';

--
-- Set default database
--
USE umamusume;

--
-- Drop procedure `sp_succession_grandparent_recommendation`
--
DROP PROCEDURE IF EXISTS sp_succession_grandparent_recommendation;

--
-- Drop procedure `sp_succession_parent_recommendation`
--
DROP PROCEDURE IF EXISTS sp_succession_parent_recommendation;

--
-- Drop procedure `sp_succession_point_sum`
--
DROP PROCEDURE IF EXISTS sp_succession_point_sum;

--
-- Set default database
--
USE umamusume;

DELIMITER $$

--
-- Create procedure `sp_succession_point_sum`
--
CREATE PROCEDURE sp_succession_point_sum (IN child BIGINT
                                        , IN parent1 BIGINT
                                        , IN grand_parent_1a BIGINT
                                        , IN grand_parent_1b BIGINT
                                        , IN parent2 BIGINT
                                        , IN grand_parent_2a BIGINT
                                        , IN grand_parent_2b BIGINT)
BEGIN
    DROP TEMPORARY TABLE IF EXISTS p1_c_relationship;
    DROP TEMPORARY TABLE IF EXISTS gpA_p1_c_relationship;
    DROP TEMPORARY TABLE IF EXISTS gpB_p1_c_relationship;

    DROP TEMPORARY TABLE IF EXISTS p2_c_relationship;
    DROP TEMPORARY TABLE IF EXISTS gpA_p2_c_relationship;
    DROP TEMPORARY TABLE IF EXISTS gpB_p2_c_relationship;

    DROP TEMPORARY TABLE IF EXISTS p1_p2_relationship;

    /* Get initial 1st parent to child relationship */
    CREATE TEMPORARY TABLE p1_c_relationship
    AS
    (
        SELECT p.relation_type
             , p.relation_point
             , p.chara_id AS parent_id
        FROM vw_succession_relation_member_types c
            JOIN vw_succession_relation_member_types p
                ON c.relation_type = p.relation_type
        WHERE c.chara_id = child
            AND p.chara_id = parent1
    );

    SET @pc1 =
    (
        SELECT SUM(relation_point)
        FROM p1_c_relationship
    );

    /* Get initial 2nd parent to child relationship */
    CREATE TEMPORARY TABLE p2_c_relationship
    AS
    (
        SELECT p.relation_type
             , p.relation_point
             , p.chara_id AS parent_id
        FROM vw_succession_relation_member_types c
            JOIN vw_succession_relation_member_types p
                ON c.relation_type = p.relation_type
        WHERE c.chara_id = child
            AND p.chara_id = parent2
    );

    SET @pc2 =
    (
        SELECT SUM(relation_point)
        FROM p2_c_relationship
    );

    /* Get parent to parent relationship */
    CREATE TEMPORARY TABLE p1_p2_relationship
    AS
    (
        SELECT p1.relation_type
             , p1.relation_point
        FROM vw_succession_relation_member_types p1
            JOIN vw_succession_relation_member_types p2
                ON p1.relation_type = p2.relation_type
        WHERE p1.chara_id = parent1
            AND p2.chara_id = parent2
    );

    SET @pp =
    (
        SELECT SUM(relation_point)
        FROM p1_p2_relationship
    );

    /* Get 1st grandparent to 1st parent of child relationship */
    CREATE TEMPORARY TABLE gpA_p1_c_relationship
    AS
    (
        SELECT gpA.relation_type
             , gpA.relation_point
             , gpA.chara_id AS parent_id
        FROM p1_c_relationship p_c
            JOIN vw_succession_relation_member_types gpA
                ON p_c.relation_type = gpA.relation_type
        WHERE gpA.chara_id = grand_parent_1a
    );

    SET @gpa_pc1 =
    (
        SELECT CASE WHEN child <> grand_parent_1a
            THEN SUM(relation_point) ELSE 0
        END
        FROM gpA_p1_c_relationship
    );

    /* Get 2nd grandparent to 1st parent of child relationship */
    CREATE TEMPORARY TABLE gpB_p1_c_relationship
    AS
    (
        SELECT gpB.relation_type
             , gpB.relation_point
             , gpB.chara_id AS parent_id
        FROM p1_c_relationship p_c
            JOIN vw_succession_relation_member_types gpB
                ON p_c.relation_type = gpB.relation_type
        WHERE gpB.chara_id = grand_parent_1b
    );

    SET @gpb_pc1 =
    (
        SELECT CASE WHEN child <> grand_parent_1b
            THEN SUM(relation_point) ELSE 0
        END
        FROM gpB_p1_c_relationship
    );

    /* Get 1st grandparent to 2nd parent of child relationship */
    CREATE TEMPORARY TABLE gpA_p2_c_relationship
    AS
    (
        SELECT gpA.relation_type
             , gpA.relation_point
             , gpA.chara_id AS parent_id
        FROM p2_c_relationship p_c
            JOIN vw_succession_relation_member_types gpA
                ON p_c.relation_type = gpA.relation_type
        WHERE gpA.chara_id = grand_parent_2a
    );

    SET @gpa_pc2 =
    (
        SELECT CASE WHEN child <> grand_parent_2a
            THEN SUM(relation_point) ELSE 0
        END
        FROM gpA_p2_c_relationship
    );

    /* Get 2nd grandparent to 2nd parent of child relationship */
    CREATE TEMPORARY TABLE gpB_p2_c_relationship
    AS
    (
        SELECT gpB.relation_type
             , gpB.relation_point
             , gpB.chara_id AS parent_id
        FROM p2_c_relationship p_c
            JOIN vw_succession_relation_member_types gpB
                ON p_c.relation_type = gpB.relation_type
        WHERE gpB.chara_id = grand_parent_2b
    );

    SET @gpb_pc2 =
    (
        SELECT CASE WHEN child <> grand_parent_2b
            THEN SUM(relation_point) ELSE 0
        END
        FROM gpB_p2_c_relationship
    );

    SET @point_sum = @pc1 + @gpa_pc1 + @gpb_pc1 + @pc2 + @gpa_pc2 + @gpb_pc2 + @pp;

    SELECT CONVERT(@pc1, INT) AS parent1_child
         , CONVERT(@gpa_pc1, INT) AS grandparentA_parent1
         , CONVERT(@gpb_pc1, INT) AS grandparentB_parent1
         , CONVERT(@pc2, INT) AS parent2_child
         , CONVERT(@gpa_pc2, INT) AS grandparentA_parent2
         , CONVERT(@gpb_pc2, INT) AS grandparentB_parent2
         , CONVERT(@pp, INT) AS parent1_parent2
         , CONVERT(@point_sum, INT) AS point_sum;
END
$$

--
-- Create procedure `sp_succession_parent_recommendation`
--
CREATE PROCEDURE sp_succession_parent_recommendation (IN child BIGINT)
BEGIN
    SELECT cd.id AS parent_recommendation_id
         , CONVERT(SUM(parent.relation_point), INT) AS parent_compatibility
    FROM vw_succession_relation_member_types parent
        JOIN vw_succession_relation_member_types child
            ON parent.relation_type = child.relation_type
        JOIN chara_data cd
            ON cd.id = parent.chara_id
    WHERE child.chara_id = child
    GROUP BY cd.id
    ORDER BY parent_compatibility DESC
           , cd.id ASC;
END
$$

--
-- Create procedure `sp_succession_grandparent_recommendation`
--
CREATE PROCEDURE sp_succession_grandparent_recommendation (IN child BIGINT
                                                         , IN parent BIGINT)
BEGIN
    DROP TEMPORARY TABLE IF EXISTS p_c_relationship;

    /* Get initial parent to child relationship */
    CREATE TEMPORARY TABLE p_c_relationship
    AS
    (
        SELECT p.relation_type
             , p.relation_point
             , p.chara_id AS parent_id
        FROM vw_succession_relation_member_types c
            JOIN vw_succession_relation_member_types p
                ON c.relation_type = p.relation_type
        WHERE c.chara_id = child
            AND p.chara_id = parent
    );

    SELECT cd.id AS grandparent_recommendation_id
         , CONVERT(SUM(gp.relation_point), INT) AS grandparent_compatibility
    FROM vw_succession_relation_member_types gp
        JOIN p_c_relationship p
            ON gp.relation_type = p.relation_type
        JOIN chara_data cd
            ON cd.id = gp.chara_id
    GROUP BY cd.id
    ORDER BY grandparent_compatibility DESC
           , cd.id ASC;
END
$$

DELIMITER ;