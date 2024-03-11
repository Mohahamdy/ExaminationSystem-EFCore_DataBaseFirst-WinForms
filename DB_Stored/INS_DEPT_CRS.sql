USE ITIDB;

-------------------------- INS_DEPT_CRS Stored --------------------------------

-- Select stored procedure for ins_dept_course
CREATE PROCEDURE Ins_Dept_Crs_Select
AS 
BEGIN
    SELECT s.fname, s.lname, d.name AS Dept_Name, c.name AS Course_name, c.duration
    FROM instructor s  
    INNER JOIN dept_ins DI ON s.ins_ID = DI.ins_ID
    INNER JOIN department d ON DI.dept_ID = d.dept_ID  
    INNER JOIN ins_course_dept icd ON s.ins_ID = icd.ins_ID
    INNER JOIN course c ON icd.course_ID = c.course_ID;
END;

-- Execute Ins_Dept_Crs_Select stored procedure
EXEC Ins_Dept_Crs_Select;

-- Insert stored procedure for ins_dept_course
CREATE PROCEDURE Ins_Dept_Crs_Insert 
    @dept_id INT, 
    @ins_id INT, 
    @course_id INT
AS 
BEGIN 
    INSERT INTO ins_course_dept 
    VALUES (@ins_id, @dept_id, @course_id);

    SELECT CONCAT('course with ID : ', @course_id, ' added to instructor with ID : ', @ins_id, ' to dept ', @dept_id);
END;

-- Execute Ins_Dept_Crs_Insert stored procedure
EXEC Ins_Dept_Crs_Insert 1, 1, 2;

-- Update stored procedure for ins_dept_course
alter PROCEDURE Ins_Dept_Crs_Update 
    @olddept_id INT, 
    @oldins_id INT, 
    @oldCourseID INT, 
	@dept_id int,
	@ins_id int,
    @course_id INT  
AS 
BEGIN 
    UPDATE ins_course_dept 
    SET course_ID = @course_id , dept_ID= @dept_id , ins_ID =@ins_id
    WHERE ins_ID = @oldins_id 
      AND dept_ID = @olddept_id 
      AND course_ID = @oldCourseID;

   SELECT 'Updated '
END;

-- Execute Ins_Dept_Crs_Update stored procedure
EXEC Ins_Dept_Crs_Update 1, 1, 2,1,1,3 ;

-- Delete stored procedure for ins_dept_course
CREATE PROCEDURE Ins_Dept_Crs_Delete  
    @dept_id INT, 
    @ins_id INT,
    @course_id INT
AS 
BEGIN 
    DELETE FROM ins_course_dept 
    WHERE ins_ID = @ins_id 
      AND dept_ID = @dept_id 
      AND course_ID = @course_id;

    SELECT 'Deleted';
END;

-- Execute Ins_Dept_Crs_Delete stored procedure
EXEC Ins_Dept_Crs_Delete 1, 1, 3;

