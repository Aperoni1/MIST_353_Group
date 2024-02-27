/*This Proceedure finds all of the locations that have an Active Fire Warning
*/
CREATE PROC AlexPeroniSP2
AS
BEGIN
    SET NOCOUNT ON;

    SELECT l.*
    FROM dbo.Location l
    INNER JOIN dbo.Fire_Warning fw ON l.LocationID = fw.LocationID
    WHERE fw.Status = 'Active';
END;

/*
EXEC AlexPeroniSP2;
*/