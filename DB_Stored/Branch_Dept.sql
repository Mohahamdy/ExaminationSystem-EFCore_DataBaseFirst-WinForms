USE ITIDB;

----------------------------------------branch_dept table -----------------------------



-- Select
create PROCEDURE Select_BranchDept
AS
BEGIN
  --  SELECT * FROM branch_dept;
  select b.name , d.name from branche b inner join branch_dept bd on b.branch_ID = bd.branch_ID
					inner join department d on bd.dept_ID= d.dept_ID 
					
END;

 	 
-- Insert
CREATE PROCEDURE Insert_BranchDept
    @branch_ID int,
    @dept_ID int
AS
BEGIN
    INSERT INTO branch_dept (branch_ID, dept_ID)
    VALUES (@branch_ID, @dept_ID);
END;

-- Update
CREATE PROCEDURE Update_BranchDept
    @branch_ID int,
    @dept_ID int
AS
BEGIN
    UPDATE branch_dept
    SET dept_ID = @dept_ID
    WHERE branch_ID = @branch_ID;
END;

-- Delete
CREATE PROCEDURE Delete_BranchDept
    @branch_ID int,
    @dept_ID int
AS
BEGIN
    DELETE FROM branch_dept
    WHERE branch_ID = @branch_ID AND dept_ID = @dept_ID;
END;
