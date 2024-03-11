USE ITIDB;


/*------------------------------------COURSE---------------------------------------------*/
 

--- select
CREATE PROCEDURE selectALLCourses 
AS
BEGIN 
SELECT * FROM course;
END

selectALLCourses

--- insert
CREATE PROCEDURE  insertCourse @Name varchar(50),
@duration int=NULL ,@grade int =NULL
AS 
Begin
insert into course (name ,duration,grade)
values(@Name,@duration,@grade)
end;
insertCourse 'C++',60,100

--- update
CREATE PROCEDURE updateCourse 
    @ID int,
    @Name varchar(50) = NULL,
    @Duration int = NULL, 
    @Grade int = NULL
AS
BEGIN
    IF @Name IS NOT NULL AND @Duration IS NOT NULL AND @Grade IS NOT NULL
    BEGIN
        UPDATE course
        SET name = @Name,
            duration = @Duration,
            grade = @Grade
        WHERE course_ID = @ID;
    END
    ELSE IF @Name IS NOT NULL AND @Duration IS NOT NULL
    BEGIN
        UPDATE course
        SET name = @Name,
            duration = @Duration
        WHERE course_ID = @ID;
    END
    ELSE IF @Name IS NOT NULL AND @Grade IS NOT NULL
    BEGIN
        UPDATE course
        SET name = @Name,
            grade = @Grade
        WHERE course_ID = @ID;
    END
    ELSE IF @Duration IS NOT NULL AND @Grade IS NOT NULL
    BEGIN
        UPDATE course
        SET duration = @Duration,
            grade = @Grade
        WHERE course_ID = @ID;
    END
	ELSE IF @Name IS NOT NULL 
    BEGIN
        UPDATE course
        SET name = @Name
        WHERE course_ID = @ID;
    END
	ELSE IF @Duration IS NOT NULL 
    BEGIN
        UPDATE course
        SET duration = @Duration
        WHERE course_ID = @ID;
    END
	ELSE IF @Grade IS NOT NULL 
    BEGIN
        UPDATE course
        SET grade = @Grade
        WHERE course_ID = @ID;
    END
    ELSE
    BEGIN
        SELECT 'No updates performed. Please provide values to update.' AS Result;
    END;
END;

selectALLCourses
updateCourse 6,null ,65,null

----Delete
CREATE FUNCTION ifcanDeleteCourse (@id int) 
RETURNS int
BEGIN 
    DECLARE @result int;

    IF NOT EXISTS (SELECT course_ID FROM exam WHERE course_ID = @ID)
        AND NOT EXISTS (SELECT course_ID FROM question WHERE course_ID = @ID)
    BEGIN
        SET @result = 1;
    END
    ELSE 
    BEGIN 
        SET @result = 0;
    END 

    RETURN @result;
END;


CREATE PROCEDURE deleteCourse @ID INT 
AS
BEGIN 
DECLARE @resultCanDeleteCourse INT;
    SELECT @resultCanDeleteCourse = dbo.ifcanDeleteCourse(@ID);
        IF @resultCanDeleteCourse = 1
        BEGIN
            DELETE FROM course_topic WHERE course_ID = @ID;
            DELETE FROM course WHERE course_ID = @ID;
        END
        ELSE
        BEGIN
            SELECT 'Sorry, the course has related records and cannot be deleted' AS Result;
        END
END


---select certin course 
 CREATE PROCEDURE selectCourse  
    @CourseID INT 
AS
BEGIN 
    SELECT * FROM course WHERE course_ID = @CourseID;
END
selectCourse 5