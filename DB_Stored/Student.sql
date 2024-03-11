
--_______________________ Student Table _______________________-- 

----- Insert
create proc insert_st 
    @fname nchar(50),
    @lname nchar(50),
    @age int,
    @address nchar(50),
    @deptId int = null
as 
    insert into student 
    values(@fname, @lname, @age, @address, @deptId)

insert_st mohamed,hamdy,25,menofia
insert_st abdallah,shafiq,22,menofia
insert_st ahmed,mahfouz,10,tala

--------------------------------------------------------------
----- Update

create proc update_st 
    @id int,
    @fname nchar(50),
    @lname nchar(50),
    @age int,
    @address nchar(50),
    @deptId int = null
as 
    update student 
    set fname = @fname,
        lname = @lname,
        age = @age,
        address = @address,
        dept_ID = @deptId
    where st_ID = @id
	
update_st 1,mohamed,hamdy,25,menofia,1
update_st 4,ali,helmi,25,menofia,3
update_st 3,shafiq,abdallah,25,menofia

--------------------------------------------------------------
----- select 

create proc select_st 
as 
    select S.fname,
           S.lname,
           S.age,
           S.address,
           D.name
    from student S 
    left outer join department D on D.dept_ID = S.dept_ID

select_st

--------------------------------------------------------------
----- delete
create proc delete_st 
    @id int
as 
    if not exists(select st_ID from st_exam where st_ID = @id) 
       and not exists(select st_ID from st_answer where st_ID = @id)
    begin
        delete from student where st_ID = @id
    end
    else 
    begin
        select 'table has relation'
    end

delete_st 4