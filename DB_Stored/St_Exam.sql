----------------------------------------------
-- Stord procedures
select * from st_exam

alter proc insert_st_exam  @stIdint int,@examId int,@totalDgree int 
as 
	begin try
		insert into st_exam values (@stIdint,@examId,@totalDgree)
	end try
	begin catch 
		 select 'Unvalid data'
	end catch

insert_st_exam 1,2,100
insert_st_exam 2,2,90
insert_st_exam 3,2,85



create proc update_st_exam @stId int,@examId int,@totalDgree int 
as 
	update st_exam 
	set total_degree = @totalDgree
	where st_ID = @stId and exam_ID = @examId

update_st_exam 1,2,95

create proc select_st_exam
as
	select trim(S.fname)+' '+trim(S.lname) as FullName ,SE.exam_ID,SE.total_degree
	from st_exam SE inner join student S 
		on S.st_ID = SE.st_ID

select_st_exam

create proc delete_st_exam @stId int,@examId int
as
	begin try 
		delete st_exam
		where st_ID = @stId and exam_ID = @examId
	end try
	begin catch 
		 select 'tabel has relation'
	end catch

delete_st_exam 1,2
