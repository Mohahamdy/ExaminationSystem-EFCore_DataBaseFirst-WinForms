using DB_Sytem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_Sytem
{
    public partial class Exam_Page : Form
    {
        ITIDBContext context = new ITIDBContext();

        int Exam_id = 0;
        int St_ID = 0;

        private int totalSeconds; // Total countdown time in seconds
        private int remainingSeconds; // Remaining seconds in the countdown
        public Exam_Page(int exam_id = 0, int st_id = 0, int dur = 0)
        {
            InitializeComponent();
            Exam_id = exam_id;
            St_ID = st_id;

            totalSeconds = dur * 60; // Convert minutes to seconds
            remainingSeconds = totalSeconds;
            UpdateTimeLabel();
        }

        private void Exam_Page_Load(object sender, EventArgs e)
        {
            try
            {

                var examQuestions = context.questions
                .Where(q => q.exams.Any(e => e.exam_ID == Exam_id))
                .Select(i => new
                {
                    i.question_ID,
                    i.text,
                    i.type,
                    options = new
                    {
                        i.question_option.opt1,
                        i.question_option.opt2,
                        i.question_option.opt3,
                        i.question_option.opt4
                    }
                })
                .ToList();


                var exam = context.exams.Where(i => i.exam_ID == Exam_id).Select(c => new { c.course.name, c.course.grade, c.duration }).FirstOrDefault();

                lbl_crsName.Text = $"Course name : {exam.name}";
                lbl_grade.Text += " ? /" + exam.grade;
                timer1.Interval = 1000;
                timer1.Start();
                int yOffset = 20; // Initial Y offset
                for (int i = 1; i <= 10; i++)
                {

                    if (i <= examQuestions.Count)
                    {
                        // Create a GroupBox to contain the question label and radio buttons
                        GroupBox groupBox = new GroupBox();
                        groupBox.Text = $"Question {i}: {examQuestions[i - 1].text}";
                        groupBox.Font = new Font(groupBox.Font.FontFamily, 12, FontStyle.Bold);
                        groupBox.Location = new System.Drawing.Point(10, yOffset);
                        groupBox.Size = new System.Drawing.Size(panel1.Width - 40, 100); // Adjust the width and height as needed
                        panel1.Controls.Add(groupBox);

                        yOffset += 110; // Increase Y offset for the next question

                        if (examQuestions[i - 1].type.Trim() == "MCQ")
                        {
                            //MessageBox.Show(examQuestions[i - 1].options.opt1);

                            var options = examQuestions[i - 1].options;

                            RadioButton[] radioButtons = new RadioButton[4];
                            // Array to store radio buttons


                            for (int j = 1; j <= 4; j++)
                            {
                                string optionText = options.GetType().GetProperty($"opt{j}").GetValue(options, null) as string;
                                if (!string.IsNullOrEmpty(optionText))
                                {
                                    radioButtons[j - 1] = new RadioButton();
                                    radioButtons[j - 1].Text = optionText;
                                    radioButtons[j - 1].AutoSize = true;
                                    radioButtons[j - 1].Location = new System.Drawing.Point(20, 20 + (j - 1) * 20);
                                    groupBox.Controls.Add(radioButtons[j - 1]);
                                }
                            }
                        }
                        else if (examQuestions[i - 1].type == "True/False")
                        {
                            // Add radio buttons for True/False type question
                            RadioButton trueRadioButton = new RadioButton();
                            trueRadioButton.Text = "True";
                            trueRadioButton.AutoSize = true;
                            trueRadioButton.Location = new System.Drawing.Point(20, 20);
                            groupBox.Controls.Add(trueRadioButton);

                            RadioButton falseRadioButton = new RadioButton();
                            falseRadioButton.Text = "False";
                            falseRadioButton.AutoSize = true;
                            falseRadioButton.Location = new System.Drawing.Point(20, 40);
                            groupBox.Controls.Add(falseRadioButton);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something Went Wrong, Please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Decrease the remaining time by one second
            remainingSeconds--;

            // Update the time label
            UpdateTimeLabel();

            // Check if the countdown has finished
            if (remainingSeconds <= 0)
            {
                timer1.Stop();
                MessageBox.Show("Exam Time finished!");
                this.Close();
            }

        }
        private void UpdateTimeLabel()
        {
            // Calculate minutes and seconds
            int minutes = remainingSeconds / 60;
            int seconds = remainingSeconds % 60;

            // Update the label text to display the remaining time in minutes and seconds
            lbl_time.Text = $"Time Left : {minutes:00}:{seconds:00} ";
        }



        /// <summary>
        /// Answer List
        /// </summary>

        List<string> selectedAnswers = new List<string>();
        async private void btn_submit_Click(object sender, EventArgs e)
        {
            try
            {

                selectedAnswers.Clear();

                ITIDBContextProcedures dbProc = new ITIDBContextProcedures(context);



                foreach (Control control in panel1.Controls)
                {
                    if (control is GroupBox groupBox)
                    {
                        string selectedAnswer = GetSelectedAnswer(groupBox);
                        selectedAnswers.Add(selectedAnswer);


                    }
                }
                // Assuming you have access to context for database operations
                var examQuestions = context.questions
                .Where(q => q.exams.Any(e => e.exam_ID == Exam_id))
                .Select(i => new
                {
                    i.question_ID,
                    i.text,
                    i.type,
                    options = new
                    {
                        i.question_option.opt1,
                        i.question_option.opt2,
                        i.question_option.opt3,
                        i.question_option.opt4
                    }
                })
                .ToList();

                for (int i = 0; i < examQuestions.Count; i++)
                {
                    // Assuming you have logic to get student's selected answer for the current question

                    var question = examQuestions[i];
                    var selectedAnswer = selectedAnswers[i];
                    // Get the correct answer for the current question
                    var correctAnswer = context.questions.FirstOrDefault(q => q.question_ID == question.question_ID)?.correct_ans;


                    // Calculate grade
                    int grade = (selectedAnswer == correctAnswer) ? 10 : 0; // You can adjust this logic based on your grading system

                    // Insert into st_answer table
                    st_answer newAnswer = new st_answer
                    {
                        exam_ID = Exam_id,
                        st_ID = St_ID,
                        question_ID = question.question_ID,
                        answer = selectedAnswer,
                        grade = grade
                    };

                    context.st_answers.Add(newAnswer);
                    //OutputParameter<int> val = new OutputParameter<int>();

                }


                // Save changes to the database
                context.SaveChanges();

                await dbProc.exam_correctionAsync(Exam_id, St_ID);
                var TotalDegree = context.st_exams.FirstOrDefault(i => i.st_ID == St_ID && i.exam_ID == Exam_id)?.total_degree;
                MessageBox.Show(TotalDegree.ToString(), "Final Grade", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something Went Wrong, Please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private string GetSelectedAnswer(GroupBox groupBox)
        {
            foreach (Control control in groupBox.Controls)
            {
                if (control is RadioButton radioButton && radioButton.Checked)
                {
                    return radioButton.Text;
                }
            }
            // If no radio button is checked, return an empty string or handle it as per your requirement
            return "";
        }
    }
}
