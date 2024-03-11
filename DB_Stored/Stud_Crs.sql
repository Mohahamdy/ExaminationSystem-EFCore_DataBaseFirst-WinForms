USE ITIDB;


/*------------------------------------STUDENT COURSE---------------------------------------------*/

select * from st_course
create proc selectAllStudentCourses 
as
select s.st_ID, s.fname , c.course_ID,c.name as Course_Name from student s inner join st_course st on s.st_ID = st.st_ID
inner join course c on st.course_ID = c.course_ID

selectAllStudentCourses


create proc selectStudentCourse @st_id int as
 select s.st_ID, CONCAT(trim(s.fname),' ',s.lname)as FullName , c.course_ID,c.name as Course_Name from student s inner join st_course st on s.st_ID = st.st_ID
inner join course c on st.course_ID = c.course_ID
where s.st_ID=@st_id


selectStudentCourse 1

delete from st_course where st_ID=10 and course_ID=20

CREATE PROCEDURE DeleteStudentCourse 
    @std_id INT,
    @course_id INT
AS 
BEGIN 
        DELETE FROM st_course WHERE st_ID = @std_id AND course_ID = @course_id;
      
END

DeleteStudentCourse 1,4


create proc UpdateStudentCourse @st_id int, @crs_id int , @newCrs_id int
as 
begin
if Exists (select 1 from course where course_ID=@newCrs_id)
begin 
update st_course set course_ID=@newCrs_id where st_ID=@st_id and course_ID=@crs_id
end
else
BEGIN
        SELECT 'Course Not Exists' AS RESULT;
    END

end

UpdateStudentCourse 1,4,10
