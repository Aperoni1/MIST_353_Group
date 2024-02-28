CREATE PROCEDURE [dbo].[GetNearestPark]
    @inputLat NVARCHAR(50),
    @inputLong NVARCHAR(50)
AS
BEGIN
    DECLARE @lat FLOAT = CAST(@inputLat AS FLOAT);
    DECLARE @long FLOAT = CAST(@inputLong AS FLOAT);

    DECLARE @nearestParkID INT;

    SELECT TOP 1 @nearestParkID = LocationID
    FROM [dbo].[Location]
    ORDER BY SQUARE((69.1 * (CAST(Lat AS FLOAT) - @lat)) * (69.1 * (CAST(Lat AS FLOAT) - @lat))) + 
                 SQUARE((69.1 * (@long - CAST(Long AS FLOAT)) * COS(CAST(Lat AS FLOAT) / 57.3))) ASC;

    SELECT *
    FROM [dbo].[Location]
    WHERE LocationID = @nearestParkID;
END;
GO

/*exec [dbo].[GetNearestPark] @inputLat = '1', @inputLong = '1';
