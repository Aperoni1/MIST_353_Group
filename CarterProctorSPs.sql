CREATE PROCEDURE CarterProctorSPs --Weather by Park Location
    @ParkName NVARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT w.*
    FROM Weather w
    INNER JOIN Location l ON w.LocationID = l.LocationID
    WHERE l.ParkName = @ParkName;


END;
