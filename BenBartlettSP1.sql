CREATE PROC spGetWeatherByState
    @State NVARCHAR(50)
AS
BEGIN
    DECLARE @Temperature DECIMAL(10, 2)
    DECLARE @Humidity DECIMAL(5, 2)
    DECLARE @WindSpeed DECIMAL(10, 2)
    DECLARE @WeatherCondition NVARCHAR(100)
    DECLARE @WeatherID INT
    DECLARE @LocationID INT 

    
    SELECT TOP 1
        @Temperature = Weather.Temperature,
        @Humidity = Weather.Humidity,
        @WindSpeed = Weather.WindSpeed,
        @WeatherCondition = Weather.WeatherCondition,
        @WeatherID = Weather.WeatherID,
        @LocationID = Location.LocationID 
    FROM 
        dbo.Weather
        INNER JOIN dbo.Location ON Weather.LocationID = Location.LocationID
    WHERE 
        Location.State = @State; 

    SELECT 
        @WeatherID AS WeatherID,
        @Temperature AS Temperature,
        @Humidity AS Humidity,
        @WindSpeed AS WindSpeed,
        @WeatherCondition AS WeatherCondition,
        @LocationID AS LocationID; 
END;
