USE ITIDB;

-------------------------- DEPT_INS Stored --------------------------------

-- Select stored procedure for dept_ins
CREATE PROCEDURE Dept_ins_Select 
AS 
BEGIN
    SELECT s.fname, s.lname, d.name AS Dept_Name, d.hire_date
    FROM instructor s  
    INNER JOIN dept_ins DI ON s.ins_ID = DI.ins_ID
    INNER JOIN department d ON DI.dept_ID = d.dept_ID;
END;

-- Execute Dept_ins_Select stored procedure
EXEC Dept_ins_Select;

-- Insert stored procedure for dept_ins
CREATE PROCEDURE Dept_ins_Insert  
    @dept_id INT,
    @ins_id INT 
AS 
BEGIN 
    INSERT INTO dept_ins 
    VALUES (@dept_id, @ins_id);

    SELECT CONCAT('Instructor with ID : ', @ins_id, ' Added to department ', @dept_id);
END;

-- Execute Dept_ins_Insert stored procedure
EXEC Dept_ins_Insert 1, 6;

-- Update stored procedure for dept_ins
CREATE PROCEDURE Dept_ins_Update 
    @dept_id INT, 
    @ins_id INT
AS 
BEGIN 
    UPDATE dept_ins 
    SET dept_ID = @dept_id 
    WHERE ins_ID = @ins_id;

    SELECT CONCAT('Instructor with ID : ', @ins_id, ' moved to department ', @dept_id);
END;

-- Execute Dept_ins_Update stored procedure
EXEC Dept_ins_Update 2, 6;

-- Delete stored procedure for dept_ins
CREATE PROCEDURE Dept_ins_Delete 
    @ins_id INT 
AS 
BEGIN 
    DELETE FROM dept_ins 
    WHERE ins_ID = @ins_id;

    SELECT CONCAT('Instructor with ID : ', @ins_id, ' has been Deleted');
END;

-- Execute Dept_ins_Delete stored procedure
EXEC Dept_ins_Delete 6;
