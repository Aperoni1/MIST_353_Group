CREATE PROCEDURE CarterProctorSP2 --GetWeatherByLocation
    @LocationID INT
AS
BEGIN
    DECLARE @Temperature DECIMAL(10, 2)
    DECLARE @Humidity DECIMAL(5, 2)
    DECLARE @WindSpeed DECIMAL(10, 2)
    DECLARE @WeatherCondition NVARCHAR(100)

    SELECT 
        @Temperature = [Temperature],
        @Humidity = [Humidity],
        @WindSpeed = [WindSpeed],
        @WeatherCondition = [WeatherCondition]
    FROM 
        [dbo].[Weather]
    WHERE 
        [LocationID] = @LocationID;

    -- Return weather details
    SELECT 
        @Temperature AS Temperature,
        @Humidity AS Humidity,
        @WindSpeed AS WindSpeed,
        @WeatherCondition AS WeatherCondition;
END;
