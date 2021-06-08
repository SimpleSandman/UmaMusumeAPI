-- 
-- Set character set the client will use to send SQL statements to the server
--
SET NAMES 'utf8mb4';

--
-- Set default database
--
USE umamusume;

--
-- Drop function `FROM_UNIXTIME_SECONDS`
--
DROP FUNCTION IF EXISTS FROM_UNIXTIME_SECONDS;

--
-- Set default database
--
USE umamusume;

DELIMITER $$

--
-- Create function `FROM_UNIXTIME_SECONDS`
--
CREATE FUNCTION FROM_UNIXTIME_SECONDS (sec BIGINT)
RETURNS DATETIME
BEGIN
    RETURN DATE_ADD(CAST('1970-01-01' AS DATETIME), INTERVAL sec SECOND);
END
$$

DELIMITER ;