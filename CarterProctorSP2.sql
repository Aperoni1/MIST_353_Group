CREATE PROCEDURE CarterProctorSP2 --Weather by location
    @LocationID INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        W.WeatherID,
        W.Temperature,
        W.Humidity,
        W.WindSpeed,
        W.WeatherCondition,
        L.LocationID,
        L.ParkName
    FROM 
        dbo.Weather W
    INNER JOIN 
        dbo.Location L ON W.LocationID = L.LocationID
    WHERE 
        W.LocationID = @LocationID;
END;
