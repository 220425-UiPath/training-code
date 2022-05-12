-- select all columns and all records from the asssociates table
Select * from associates;
-- select all associates that live in NJ provide all columns
Select * from associates where state like 'NJ';
-- count how many associates live in a certain state
Select count(id), state from associates group by associates.state; 
-- count how many trainiers are based on a campus
Select count(id), campus from trainers group by campus;
-- present all campuses with less than 2 trainers
Select count(id), campus from trainers group by campus having count(id) < 2;
-- count how many trainers are based on a campus order results by descending order of the trainer count
Select count(id), campus from trainers group by campus order by count(id) desc;

-- Left joins
-- we match records based on id values in the associates table that match associate_id values in the cohorts table
-- this statement gives me all the associates that may or may not be in a cohort
select * from associates left join cohorts on associates.id = cohorts.associate_id;

-- getting all associates in a cohort
-- using an inner join, I'm only getting records that match the join condition
select * from associates inner join cohorts on associates.id = cohorts.associate_id;

select * from associates right join cohorts on associates.id = cohorts.associate_id;

-- select all associates and trainers regardless of whether they're in a cohort or not
select * from associates full outer join cohorts on associates.id = cohorts.associate_id full outer join trainers on cohorts.trainer_id = trainers.id;


-- SET Operations
-- Get all associates not in a cohort
(Select name, state from associates) except (select name, state from associates inner join cohorts on associates.id = cohorts.associate_id)
-- same thing but using joins
select name, state from associates left join cohorts on associates.id = cohorts.associate_id where trainer_id is null;

-- Subqueries
-- Get all associates not in a cohort
Select name, state from associates where id not in (select associate_id from cohorts); 

-- get all associates in a cohort
select name, state from associates where id in (select associate_id from cohorts);

-- joins are useful in getting data from across tables 
-- set operations are useful for aggregating the same data that is stored in multiple tables
-- subqueries are useful in filtering out results based on another query's condition

-- Activity
-- Add 5 associates to the associate table
-- Insert rows into table 'associates' in schema '[dbo]'
INSERT INTO [dbo].[associates]
( -- Columns to insert data into
 [name], [state], [reva_points]
)
VALUES
( -- First row: values for the columns in the list above
 'Matthew', 'NY', 150
),
( -- Second row: values for the columns in the list above
 'Diahandra', 'MS', 150
),
( -- Second row: values for the columns in the list above
 'Sylvester', 'MD', 150
),
( -- Second row: values for the columns in the list above
 'Gildas', 'WV', 150
),
( -- Second row: values for the columns in the list above
 'Anna', 'NY', 150
)
-- Add more rows here
GO

select * from associates;

-- Get all trainers based in a certain campus
SELECT * from trainers where campus like 'Florida';

-- Get the count of trainers from campuses
Select count(*), campus from trainers group by campus order by count(*) desc;
Select count(*), campus from trainers group by campus order by count(*) asc;

-- Get all trainers without assocs
-- Join
Select name, campus from trainers left join cohorts on trainers.id = cohorts.trainer_id where associate_id is null;
-- Set operation
(Select name, campus from trainers) EXCEPT (Select name, campus from trainers inner join cohorts on trainers.id = cohorts.trainer_id);
-- Subquery 
Select name, campus from trainers where id not in (select trainer_id from cohorts);

-- get all associates mapped to a trainer
-- Join
Select associates.name as 'Associate', trainers.name as 'Trainer' from associates inner join cohorts on associates.id = cohorts.associate_id inner join trainers on cohorts.trainer_id = trainers.id;

-- Get all associates not in a cohort
-- Set operations
(Select name, state from associates) except (select name, state from associates inner join cohorts on associates.id = cohorts.associate_id)
-- same thing but using joins
select name, state from associates left join cohorts on associates.id = cohorts.associate_id where trainer_id is null;
-- Subqueries
Select name, state from associates where id not in (select associate_id from cohorts); 