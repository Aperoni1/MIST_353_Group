CREATE PROCEDURE CarterProctorSP2_GetWeatherByLocation
    @LocationID INT
AS
BEGIN
    DECLARE @Temperature DECIMAL(10, 2);
    DECLARE @WeatherCondition NVARCHAR(100);

    -- Get the weather details for the given location
    SELECT 
        @Temperature = [Temperature],
        @WeatherCondition = [WeatherCondition]
    FROM 
        [dbo].[Weather]
    WHERE 
        [LocationID] = @LocationID;

    -- Return weather details
    SELECT 
        @Temperature AS Temperature,
        @WeatherCondition AS WeatherCondition;
END;

