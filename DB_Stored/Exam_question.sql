use ITIDB
--_______________________ Exam_question Table _______________________-- 

-- insert data
create proc insert_ExamQuestion
	@ExamID int,
	@QuestionID int
as
Begin
	Begin Try
		insert into exam_question(exam_ID,quesation_ID)
		values (@ExamID, @QuestionID);
	End Try
	Begin Catch
		select 'An error occurred while inserting data into the exam question.';
		select 'Error Description: ' + ERROR_MESSAGE();
	End Catch;
End;


-- calling procedure (insert exam question)
Exec insert_ExamQuestion 
	@ExamID = 1,
	@QuestionID = 13;

	
-------------------------------------------------------------------------

-------------------------------------------------------------------------


-- select exam questions
create proc select_ExamQuestions
	@examId int
as
Begin
	
	If Exists (select 1 from exam_question where exam_ID = @examId )
	Begin 
		select * From exam_question
		where exam_ID = @examId;
	End;
	else
	Begin
		select 'There is No Exam with this Id '; 
	End;
End;

-- calling procedure (select exam questions)
EXEC select_ExamQuestions @examId = 1;
EXEC select_ExamQuestions @examId = 3332; --There is No exam questions with this Id


-------------------------------------------------------------------------
-- Update exam question data
create proc update_examQuestion
	@ExamID int,
	@oldQuestionId int,
	@newQuestionId int
as
Begin
	Begin Try
		if Not Exists ( select 1 from exam_question where exam_ID = @ExamID and quesation_ID=@oldQuestionId)
			Begin
				select 'There is No exam or question with Provided id'; 
			End;
		else
			Begin
				update exam_question 
				set quesation_ID = @newQuestionId
				where exam_ID = @ExamID and quesation_ID=@oldQuestionId;

				select 'Exam Question updated successfully.';
			End;
	End Try

	Begin Catch
		Declare @ErrorMessage varchar(400);
        select @ErrorMessage = ERROR_MESSAGE();
		select @ErrorMessage;
	End Catch;
End;

-- calling procedure (update question)
Exec update_examQuestion 1, 16, 11; -- Exam Question Updated Successfully
Exec update_examQuestion 3, 11, 8;  -- error -> There is No exam question with Provided id


-------------------------------------------------------------------------



-- delete all exam questions

create procedure Delete_AllExamQuestions
    @ExamId int
as
begin
    begin try
        if not exists (select 1 from exam_question where exam_ID = @ExamId)
			begin
			    print 'There is No Exam with Provided Id';
			end
        else
			begin
			    delete from exam_question where exam_ID = @ExamId;
				print 'Exam Questions Deleted Successfully!';
			end;
    end try
    begin catch
        declare @errorMessage varchar(4000);
        select @errorMessage = ERROR_MESSAGE();
        print 'An Error Occurred: ' + @errorMessage;
    end catch;
end;

-- calling procedure (delete question)
Exec Delete_AllExamQuestions 1; -- exam questions Deleted Successfully!
Exec Delete_AllExamQuestions 3; --There is No exam Questions with Provided id


-------------------------------------------------------------------------
---- delete one exam question

create procedure Delete_ExamQuestion
    @questionId int
as
begin
    begin try
        if not exists (select 1 from exam_question where quesation_ID = @questionId)
			begin
			    print 'There is No Question with Provided Id';
			end
        else
			begin
			    delete from exam_question where quesation_ID = @questionId;
				print 'Question Deleted Successfully!';
			end;
    end try
    begin catch
        declare @errorMessage varchar(4000);
        select @errorMessage = ERROR_MESSAGE();
        print 'An Error Occurred: ' + @errorMessage;
    end catch;
end;

-- calling procedure (delete one question from exam)
Exec Delete_ExamQuestion 9; --question Deleted Successfully!
Exec Delete_ExamQuestion 7; --There is No Question with Provided id

