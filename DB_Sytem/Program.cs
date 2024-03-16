namespace DB_Sytem
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            //Application.Run(new Student_HomePage());
            //Application.Run(new Instructor_HomePage(1, "abdallah"));
            //Application.Run(new Instructor_Exam(1,"mostafa"));
            //Application.Run(new ExamDetails(0, ""));
            //Application.Run(new CreateQuestions(2,"ahmed"));
            //Application.Run(new Student_Crud_Courses(1, "mostafa"));
            //Application.Run(new Student_Crud(1, "mostafa"));
            Application.Run(new Login());


        }
    }
}