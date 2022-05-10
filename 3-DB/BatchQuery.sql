drop table trainers;
create table trainers (
    id INT IDENTITY(1000, 1) PRIMARY KEY,
    name text not null,
    campus text not null,
    caffeine_level int not null
);
-- identity is a keyword that autogenerates a primary key for you by incrementing its value
-- Create a new table called '[associates]' in schema '[dbo]'
-- Drop the table if it already exists
IF OBJECT_ID('[dbo].[associates]', 'U') IS NOT NULL
DROP TABLE [dbo].[associates]
GO
-- Create the table in the specified schema
CREATE TABLE [dbo].[associates]
(
    [Id] INT Identity(1,1) PRIMARY KEY, -- Primary Key column
    [name] text not null,
    [state] text not null,
    [reva_points] int not null
);
GO
-- Create a new table called '[cohorts]' in schema '[dbo]'
-- Drop the table if it already exists
IF OBJECT_ID('[dbo].[cohorts]', 'U') IS NOT NULL
DROP TABLE [dbo].[cohorts]
GO
-- Create the table in the specified schema
CREATE TABLE [dbo].[cohorts]
(
    [Id] INT IDENTITY(1,1) PRIMARY KEY, -- Primary Key column
    [associate_id] INT REFERENCES associates(id), -- create a foreign key reference 
    [trainer_id] int REFERENCES trainers(id) -- create a FK column called trainer_id that would hold values of the PK of trainers table
);
GO
-- 3 tables: trainers, associates, cohorts

-- add data to tables
-- add data to trainers table

-- Insert rows into table 'trainers' in schema '[dbo]'
INSERT INTO [dbo].[trainers]
( -- Columns to insert data into
 [name], [campus], [caffeine_level]
)
VALUES
( -- First row: values for the columns in the list above
 'Marielle', 'Reston', 50
),
( -- Second row: values for the columns in the list above
 'Pushpinder', 'Texas', 40
),
(
    'Juniper', 'Florida', 80
),
(
    'Stephen', 'Reston', 0
)
-- Add more rows here
GO

-- show trainers in table
-- Select rows from a Table or View '[trainers]' in schema '[dbo]'
SELECT * FROM [dbo].[trainers];
