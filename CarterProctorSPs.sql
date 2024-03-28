CREATE PROCEDURE GetParkStatus
    @LocationID INT
AS
BEGIN
    DECLARE @WeatherCondition NVARCHAR(50)
    DECLARE @ActiveFireWarnings INT

    -- Get the current weather condition for the park
    SELECT @WeatherCondition = [WeatherCondition]
    FROM [dbo].[Weather]
    WHERE [LocationID] = @LocationID;

    -- Check for active fire warnings for the park
    SELECT @ActiveFireWarnings = COUNT(*)
    FROM [dbo].[Fire_Warning]
    WHERE [LocationID] = @LocationID
    AND [Status] = 'Active';

    -- Determine park status based on weather and fire warnings
    IF (@WeatherCondition = 'Extreme' OR @ActiveFireWarnings > 0)
    BEGIN
        -- Park is closed due to extreme weather or active fire warnings
        SELECT 'Closed' AS ParkStatus;
    END
    ELSE
    BEGIN
        -- Park is open
        SELECT 'Open' AS ParkStatus;
    END
END;
