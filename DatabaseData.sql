USE [M353Group];

-- Inserting data into the Location table
INSERT INTO [dbo].[Location] ([Address], [City], [State], [Zip], [Long], [Lat], [ParkName])
VALUES
('123 Main St', 'Anytown', 'CA', '12345', '123.456', '789.012', 'Central Park'),
('456 Oak St', 'Othertown', 'NY', '54321', '987.654', '321.098', 'Oak Park'),
('789 Pine St', 'Smalltown', 'TX', '67890', '456.789', '210.987', 'Pine Park'),
('321 Elm St', 'Hometown', 'FL', '98765', '654.321', '109.876', 'Elm Park'),
('555 Maple St', 'Newtown', 'WA', '54321', '321.654', '987.210', 'Maple Park');

-- Inserting data into the Weather table
INSERT INTO [dbo].[Weather] ([LocationID], [Temperature], [Humidity], [WindSpeed], [WeatherCondition])
VALUES
(1, 75.5, 60.3, 10.2, 'Sunny'),
(2, 68.7, 55.0, 8.5, 'Partly Cloudy'),
(3, 80.0, 65.5, 12.0, 'Rainy'),
(4, 72.3, 58.2, 9.8, 'Cloudy'),
(5, 85.1, 62.8, 11.5, 'Sunny');

-- Inserting data into the Fire_Warning table
INSERT INTO [dbo].[Fire_Warning] ([TimeLastUpdated], [TimeFirstReported], [Status], [LocationID])
VALUES
('2024-02-27 08:00:00', '2024-02-27 07:45:00', 'Active', 1),
('2024-02-26 12:30:00', '2024-02-26 12:15:00', 'Inactive', 2),
('2024-02-28 10:00:00', '2024-02-28 09:45:00', 'Active', 3),
('2024-02-26 14:20:00', '2024-02-26 14:10:00', 'Inactive', 4),
('2024-02-27 09:30:00', '2024-02-27 09:15:00', 'Active', 5);
