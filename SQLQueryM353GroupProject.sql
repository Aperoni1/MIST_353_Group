USE [M353Group];
GO

-- Create Location table
CREATE TABLE [dbo].[Location](
    [LocationID] INT IDENTITY(1,1) PRIMARY KEY,
    [Address] NVARCHAR(50) NULL,
    [City] NVARCHAR(50) NULL,
    [State] NVARCHAR(50) NULL,
    [Zip] NVARCHAR(50) NULL,
    [Long] NVARCHAR(50) NULL,
    [Lat] NVARCHAR(50) NULL,
    [ParkName] NVARCHAR(MAX) NULL
);

-- Create Weather table with LocationID as Foreign Key
CREATE TABLE [dbo].[Weather](
    [WeatherID] INT IDENTITY(1,1) PRIMARY KEY,
    [LocationID] INT FOREIGN KEY REFERENCES [dbo].[Location]([LocationID]),
    [Temperature] DECIMAL(10,2) NULL,
    [Humidity] DECIMAL(5,2) NULL,
    [WindSpeed] DECIMAL(10,2) NULL,
    [WeatherCondition] NVARCHAR(100) NULL
);

-- Create Fire_Warning table
CREATE TABLE [dbo].[Fire_Warning](
    [WarningID] INT IDENTITY(1,1) PRIMARY KEY,
    [TimeLastUpdated] DATETIME,
    [TimeFirstReported] DATETIME,
    [Status] CHAR(36),
    [LocationID] INT FOREIGN KEY REFERENCES [dbo].[Location]([LocationID])
);

