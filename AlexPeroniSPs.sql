CREATE PROCEDURE AlexPeroniSPs
    @TimeLastUpdated DATETIME,
    @TimeFirstReported DATETIME,
    @Status CHAR(36),
    @LocationID INT
AS
BEGIN
    SET NOCOUNT ON;

    -- Insert new entry into Fire_Warning table
    INSERT INTO dbo.Fire_Warning (TimeLastUpdated, TimeFirstReported, Status, LocationID)
    VALUES (@TimeLastUpdated, @TimeFirstReported, @Status, @LocationID);
END;
/*
EXEC AlexPeroniSPs'2024-02-17 12:00:00', '2024-02-20 11:00:00', 'Inactive', 1;
/*