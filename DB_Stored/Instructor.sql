USE ITIDB;


-------------------------- instructor Stored --------------------------------

-- Select stored procedure for instructors
CREATE PROCEDURE INS_select 
AS 
BEGIN
    SELECT * FROM instructor;
END;

 
EXEC INS_select;

-- Insert stored procedure for instructors
CREATE PROCEDURE INS_insert  
    @ins_fname VARCHAR(50),
    @ins_lname VARCHAR(50),
    @ins_salary VARCHAR(50),
    @ins_degree VARCHAR(50)
AS
BEGIN
    BEGIN TRY
        INSERT INTO instructor 
        VALUES (@ins_fname, @ins_lname, @ins_salary, @ins_degree, GETDATE());
        
        SELECT 'Instructor Inserted';
    END TRY
    BEGIN CATCH
        SELECT 'Error found while Inserting';
    END CATCH;
END;

 
EXEC INS_insert 'ahmed', 'mahfouz', '5000', 'Master';

-- Update stored procedure for instructors
CREATE PROCEDURE INS_update 
    @INS_id INT, 
    @ins_fname VARCHAR(50),
    @ins_lname VARCHAR(50),
    @ins_salary VARCHAR(50),
    @ins_degree VARCHAR(50)
AS 
BEGIN 
    BEGIN TRY
        UPDATE instructor 
        SET fname = @ins_fname, 
            lname = @ins_lname, 
            salary = @ins_salary, 
            Degree = @ins_degree
        WHERE ins_ID = @INS_id;
        
        SELECT 'Instructor updated';
    END TRY
    BEGIN CATCH
        SELECT 'Error found while updating';
    END CATCH;
END;

 
EXEC INS_update 5, 'Ahmed', 'Mahfouz', '20000', 'PHD';

-- Delete stored procedure for instructors
CREATE PROCEDURE INS_delete  
    @INS_id INT 
AS 
BEGIN
    DELETE FROM instructor 
    WHERE ins_ID = @INS_id;

    SELECT CONCAT('Instructor with ID : ', @INS_id, ' Deleted');
END;

 
EXEC INS_delete 4;

-- Execute INS_select stored procedure to see the updated list of instructors
EXEC INS_select;
