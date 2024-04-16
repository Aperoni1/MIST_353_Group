CREATE PROCEDURE AlexPeroniSP2
AS
BEGIN
    SET NOCOUNT ON;
    
    SELECT 
        WarningID,
        TimeLastUpdated,
        TimeFirstReported,
        Status,
        LocationID
    FROM 
        dbo.Fire_Warning;
END;
/*
execute AlexPeroniSP2;
*/
