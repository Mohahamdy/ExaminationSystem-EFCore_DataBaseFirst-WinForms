USE ITIDB;

/*------------------------------------COURSE TOPIC---------------------------------------------*/

-- select all

create  PROCEDURE SelectAllTopics
AS 
BEGIN 
   select t.course_ID, c.name as Course_Name, t.topic from course c inner join course_topic t on c.course_ID= t.course_ID
 
END

SelectAllTopics

--- specific course topic

create  PROCEDURE SelectAllTopicsToSpecificCOurse 
    @CourseID INT
AS 
BEGIN 
    IF EXISTS (SELECT 1 FROM course WHERE course_ID = @CourseID)
    BEGIN
        IF EXISTS (SELECT 1 FROM course_topic WHERE course_ID = @CourseID)
        BEGIN
		select t.course_ID, c.name as Course_Name, t.topic from course c inner join course_topic t on c.course_ID= t.course_ID
			where t.course_ID = @CourseID
            
        END
        ELSE
        BEGIN
            SELECT 'Course ID does not have any topics.' AS Result;
        END
    END
    ELSE
    BEGIN
        SELECT 'Course ID does not exist.' AS Result;
    END
END
SelectAllTopicsToSpecificCOurse 1

-------- Update
CREATE PROCEDURE UpdateTopic 
    @Topic VARCHAR(100) = NULL,
    @CourseID INT = NULL,
    @NewCourseID INT = NULL,
    @NewTopic VARCHAR(100) = NULL
AS
BEGIN 
IF @Topic IS NOT NULL AND  @CourseID IS NOT NULL
BEGIN 
    IF @NewCourseID IS NOT NULL AND @NewTopic IS NULL
    BEGIN
        IF EXISTS (SELECT 1 FROM course_topic WHERE course_ID = @CourseID AND topic = @Topic)
           AND EXISTS (SELECT 1 FROM course WHERE course_ID = @NewCourseID)
		    
        BEGIN
            UPDATE course_topic SET course_ID = @NewCourseID 
            WHERE course_ID =  @CourseID AND topic = @Topic;
            SELECT 'Course ID updated successfully.' AS Result;
        END
        ELSE
        BEGIN
            SELECT 'Failed to update course ID. Check your input.' AS Result;
        END
    END
    ELSE IF @NewTopic IS NOT NULL AND @NewCourseID IS NULL
    BEGIN 
        IF EXISTS (SELECT 1 FROM course_topic WHERE course_ID = @CourseID AND topic = @Topic)
        BEGIN
            UPDATE course_topic SET topic = @NewTopic
            WHERE course_ID = @CourseID AND topic = @Topic;
            SELECT 'Topic updated successfully.' AS Result;
        END
        ELSE
        BEGIN
            SELECT 'Failed to update topic. Check your input.' AS Result;
        END
    END
    ELSE 
    BEGIN
        SELECT 'At least one of NewCourseID or NewTopic should be provided for an update operation.' AS Result;
    END
	END
	ELSE
	BEGIN 
	SELECT 'please enter Topic OR CourseID.' AS Result;
	End 
END

-------- Delete 
CREATE PROCEDURE DeleteETopic 
    @Topic VARCHAR(100)=NULL,
    @CourseID INT=NULL
AS 
BEGIN 
    IF EXISTS(SELECT 1 FROM course_topic WHERE course_ID = @CourseID AND topic = @Topic)
	AND @Topic IS NOT NULL AND @CourseID IS NOT NULL
    BEGIN
        DELETE FROM course_topic WHERE course_ID = @CourseID;
        SELECT 'Topic deleted successfully.' AS Result;
    END
    ELSE 
    BEGIN
        SELECT 'Sorry, the specified topic does not exist for the given course ID.' AS Result;
    END
END
