-- Use ITIDB database
use ITIDB

--_______________________ Exam  Table _______________________-- 

--insert 
create proc insert_exam 
    @time time(7),
    @date date,
    @duration int,
    @crsID int = null
as 
    insert into exam 
    values(@time, @date, @duration, @crsID)

	insert_exam '10:30','1-1-2025',90
insert_exam '9:30','1-30-2025',90,2

--------------------------------------------------------------
----- update 

create proc update_exam 
    @id int,
    @time time(7),
    @date date,
    @duration int,
    @crsID int = null
as 
    update exam 
    set time = @time,
        date = @date,
        duration = @duration,
        course_ID = @crsID
    where exam_ID = @id


update_exam 2,'10:30','2025-1-1',60,3

--------------------------------------------------------------
----- select 

create proc select_exam 
as 
    select e.time,
           e.date,
           e.duration,
           c.name as courseName
    from exam e 
    inner join course c on c.course_ID = e.course_ID
select_exam


--------------------------------------------------------------
----- delete


create proc delete_exam 
    @id int
as 
    if not exists(select exam_ID from st_answer where exam_ID = @id) 
       and not exists(select exam_ID from st_exam where exam_ID = @id) 
       and not exists(select exam_ID from exam_question where exam_ID = @id)
    begin
        delete from exam where exam_ID = @id
    end
    else 
    begin
        select 'table has relation'
    end

	delete_exam 1

--------------------------------------------------------------
----- Select Exam Details with Course and Question

select E.exam_ID,
       C.name as courseName,
       Q.text,
       Q.type
from exam E 
inner join exam_question EQ on E.exam_ID = EQ.exam_ID 
inner join question Q on Q.question_ID = EQ.quesation_ID
inner join course C on C.course_ID = Q.course_ID