
use ITIDB
--_______________________ st_answer Table _______________________-- 


-- insert data
create proc insert_StudentAnswers
	@ExamID int,
	@StudentID int,
	@QuestionID int,
	@Answer varchar(max),
	@Grade int
as
Begin
	Begin Try
		if not exists (select * from st_answer where exam_ID = @ExamID and st_ID=@StudentID and question_ID=@QuestionID )
			begin 
				insert into st_answer(exam_ID, st_ID, question_ID, answer, grade)
				values (@ExamID, @StudentID, @QuestionID, @Answer, @Grade);
			end;
		else
			select 'This question answer for this student in this exam is already exist.';
	End Try
	Begin Catch
		select 'An error occurred while inserting the Student Answers.';
		select 'Error Description: ' + ERROR_MESSAGE();
	End Catch;
End;


---- calling procedure (insert student answers)
Exec insert_StudentAnswers  
	@ExamID =1,
	@StudentID =2,
	@QuestionID =11,
	@Answer ='T',
	@Grade =2;  --correct answer (full mark)

Exec insert_StudentAnswers  
	@ExamID =1,
	@StudentID =2,
	@QuestionID =13,
	@Answer ='No',
	@Grade =0;  --wrong answer (minus)

Exec insert_StudentAnswers
	@ExamID =1,
	@StudentID =2,
	@QuestionID =13,
	@Answer ='No',
	@Grade =0;   --already exist


	
-------------------------------------------------------------------------

-- select student answers in an exam
create proc select_StudentAnswers
	@ExamID int,
	@StudentID int
as
Begin
	If Exists (select 1 from st_answer where exam_ID = @ExamID and st_ID=@StudentID )
		Begin 
			select * from  st_answer 
			where exam_ID = @ExamID and st_ID=@StudentID
		End;
	else
		Begin
			select 'There is no answers for this student in this Exam'; 
		End;
End;

-- calling procedure (select all questions for course)
EXEC select_StudentAnswers @ExamID =1, @StudentID =2;
EXEC select_StudentAnswers @ExamID =10, @StudentID =2; --There is no answers for this student in this course


---------------------------------------------------------------------------

-- Update student answer
create proc update_StudentAnswer
	@ExamID int,
	@StudentID int,
	@QuestionID int,
	@Answer varchar(max),
	@Grade int
as
Begin
	Begin Try
		if Not Exists ( select 1 from st_answer where exam_ID = @ExamID and st_ID=@StudentID )
			Begin
				select 'There is no answers for this student in this Exam'; 
			End;
		else
		Begin
			update st_answer 
			set answer=@Answer,
				grade=@Grade
			where exam_ID = @ExamID and st_ID=@StudentID and question_ID =@QuestionID

			select 'Student Answer updated successfully.';
		End;
	End Try

	Begin Catch
		Declare @ErrorMessage varchar(400);
        select @ErrorMessage = ERROR_MESSAGE();
		select @ErrorMessage;
	End Catch;
End;

-- calling procedure (student answer)
Exec update_StudentAnswer 1, 2 , 13, 'hello', 7; -- student answer Updated Successfully
Exec update_StudentAnswer 1, 5 , 9, 'F', 3; -- error -> There is no answers for this student in this Exam


---------------------------------------------------------------------------


-- delete all answers for a student

create procedure Delete_StudentAnswers
    @ExamID int,
	@StudentID int
as
begin
    begin try
        if not exists (select 1 from st_answer where exam_ID = @ExamID and st_ID=@StudentID)
			begin
			    print 'There is No Answers for This Student';
			end
        else
			begin
			    delete from st_answer where exam_ID = @ExamID and st_ID=@StudentID;
				print 'All Answers for this student are Deleted Successfully!';
			end;
    end try
    begin catch
        declare @errorMessage varchar(4000);
        select @errorMessage = ERROR_MESSAGE();
        print 'An Error Occurred: ' + @errorMessage;
    end catch;
end;

-- calling procedure (delete all answers for a student)
Exec Delete_StudentAnswers 1,2; --All Answers for this student is Deleted Successfully!
Exec Delete_StudentAnswers 1,2; --There is No Answers for This Student



---------------------------------------------------------------------------


-- delete a specific answer for a student

create procedure Delete_StudentOneAnswer
    @ExamID int,
	@StudentID int,
	@QuestionID int
as
begin
    begin try
        if not exists (select 1 from st_answer where exam_ID = @ExamID and st_ID=@StudentID and question_ID=@QuestionID)
			begin
			    print 'There is No Answer with Provided Id for this student';
			end
        else
			begin
			    delete from st_answer where exam_ID = @ExamID and st_ID=@StudentID and question_ID=@QuestionID;
				print 'This Answer for this student is Deleted Successfully!';
			end;
    end try
    begin catch
        declare @errorMessage varchar(4000);
        select @errorMessage = ERROR_MESSAGE();
        print 'An Error Occurred: ' + @errorMessage;
    end catch;
end;

-- calling procedure (delete a specific answer for a student)
Exec Delete_StudentOneAnswer 1,1,13; --This Answer for this student is Deleted Successfully!
Exec Delete_StudentOneAnswer 1,2,11; --There is No Answer with Provided Id for this student






