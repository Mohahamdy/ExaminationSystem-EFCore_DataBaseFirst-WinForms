use ITIDB

--_______________________ Questions Table _______________________-- 
select * from question
select * from question_option
 -- insert data
create proc insert_Question
	@Text varchar(max),
	@Type varchar(15),
	@CorrectAns varchar(max),
	@Grade int,
	@CourseID int,
	@option1 varchar(max)=null,  --default values if the questions's type is T&F
	@option2 varchar(max)=null,
	@option3 varchar(max)=null,
	@option4 varchar(max)=null
as
Begin
	Begin Try
		insert into question(text, type, correct_ans, grade, course_ID)
		values (@Text, @Type, @CorrectAns, @Grade, @CourseID);
		if(@option1 is not null and @option2 is not null and @option3 is not null and @option4 is not null)
			begin
				DECLARE @lastInsertedID INT;  
				SET	@lastInsertedID = SCOPE_IDENTITY();    --to get last inserted row into question table
				insert into question_option(question_ID, opt1, opt2, opt3, opt4)
				values (@lastInsertedID, @option1, @option2, @option3, @option4);
			end;
	End Try
	Begin Catch
		select 'An error occurred while inserting data into the Question.';
		select 'Error Description: ' + ERROR_MESSAGE();
	End Catch;
End;

Exec insert_Question
	@Text = 'how to be creative?',
	@Type = 'MCQ',
	@CorrectAns = 'ok',
	@Grade = 2,
	@CourseID = 1,
	@option1='hello',
	@option2='hi',
	@option3='ok',
	@option4='bye';

-------------------------------------------------------------------------

-- select all data
create proc select_AllQuestions
	@courseID int
as
Begin
	
	If Exists (select * from question where course_ID = @courseID )
		Begin 
			select * From question
			where course_ID = @courseID
		End;
	else
		Begin
			select 'There is no questions for this course'; 
		End;
End;

-- calling procedure (select all questions for course)
EXEC select_AllQuestions @courseId = 1;
EXEC select_AllQuestions @courseId = 3332; --There is No questions for this course
-------------------------------------------------------------------------


-- Update question data
create proc update_question
	@questionId int,
    @Text varchar(max),
	@Type varchar(3),
	@CorrectAns varchar(max),
	@Grade int,
	@CourseID int
as
Begin
	Begin Try
		if Not Exists ( select 1 from question where question_ID = @questionId )
			Begin
				select 'There is No question with Provided id'; 
			End;
		else
		Begin
			update question 
			set text = @Text,
				type = @Type,
				correct_ans = @CorrectAns,
				grade=@Grade,
				course_ID=@CourseID
			where question_ID = @questionId;

			select 'Question updated successfully.';
		End;
	End Try

	Begin Catch
		Declare @ErrorMessage varchar(400);
        select @ErrorMessage = ERROR_MESSAGE();
		select @ErrorMessage;
	End Catch;
End;

-- calling procedure (update question)
Exec update_question 3, 'New Sample Question1' , 'TF', 'F', 10, 1; -- Exam Updated Successfully
Exec update_question 10, 'New Sample Question2' , 'MCQ', 'F', 10, 5; -- error -> There is No question with Provided id


-------------------------------------------------------------------------
-- delete question

create procedure Delete_Question
    @questionId int
as
begin
    begin try
        if not exists (select 1 from question where question_ID = @questionId)
			begin
			    print 'There is No Question with Provided Id';
			end
        else
			begin
			    if not exists ( (select 1 from exam_question where quesation_ID = @questionId) union all (select 1 from st_answer where question_ID = @questionId) )
					begin
						delete from question_option where question_ID = @questionId
						delete from question where question_ID = @questionId;
						print 'Question Deleted Successfully!';
					end;
				else
					select 'This question is already used in Exam_Questions table and can`t be deleted'
			end;
    end try
    begin catch
        declare @errorMessage varchar(4000);
        select @errorMessage = ERROR_MESSAGE();
        print 'An Error Occurred: ' + @errorMessage;
    end catch;
end;
