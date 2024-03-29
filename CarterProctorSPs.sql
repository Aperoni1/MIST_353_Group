CREATE PROCEDURE CarterProctorSPs --Weather by park Name
    @ParkName NVARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT *
    FROM Location
    WHERE ParkName = @ParkName;

    SELECT *
    FROM Weather
    WHERE LocationID IN (SELECT LocationID FROM Location WHERE ParkName = @ParkName);

    SELECT *
    FROM Fire_Warning
    WHERE LocationID IN (SELECT LocationID FROM Location WHERE ParkName = @ParkName);
END;
