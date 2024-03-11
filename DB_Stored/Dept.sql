USE ITIDB;
----------------------------------department table----------------------------------

-- Select
CREATE PROCEDURE Select_Department
AS
BEGIN
    SELECT * FROM department;
END;

-- Insert
create PROCEDURE Insert_Department
    @name nchar(50),
    @manager_ID int
AS
BEGIN
    INSERT INTO department ( name, manger_ID, hire_date)
    VALUES ( @name, @manager_ID, GETDATE());

	--Declare @dept_id int
	--set @dept_id = (select dept_ID from department where name = @name)
	--EXEC Dept_ins_Insert @dept_id ,@manager_ID

END;

Insert_Department 'c++',6
Dept_ins_Select
Ins_select
 
 Select_Department




-- Update
CREATE PROCEDURE Update_Department
    @dept_ID int,
    @name nchar(50),
    @manager_ID int,
    @hire_date date
AS
BEGIN
    UPDATE department
    SET name = @name, manger_ID = @manager_ID, hire_date = @hire_date
    WHERE dept_ID = @dept_ID;
END;

-- Delete
CREATE PROCEDURE Delete_Department
    @dept_ID int
AS
BEGIN
    DELETE FROM [dbo].[department]
    WHERE dept_ID = @dept_ID;
END;


Delete_Department 9
