CREATE PROCEDURE CarterProctorSPs --GetParkName
    @LocationID INT
AS
BEGIN
    DECLARE @ParkName NVARCHAR(100);

    -- Get the park name for the given location
    SELECT @ParkName = [ParkName]
    FROM [dbo].[Park]
    WHERE [LocationID] = @LocationID;

    -- Return the park name
    SELECT @ParkName AS ParkName;
END;
