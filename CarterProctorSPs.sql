CREATE PROCEDURE GetHumidityByLocation
    @LocationID INT
AS
BEGIN
    DECLARE @Humidity DECIMAL(5, 2)
    SELECT 
        @Humidity = [Humidity]
    FROM 
        [dbo].[Weather]
    WHERE 
        [LocationID] = @LocationID;

    SELECT @Humidity AS Humidity;
END;
