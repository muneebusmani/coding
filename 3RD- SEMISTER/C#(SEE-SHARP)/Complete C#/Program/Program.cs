// using System.Runtime.ConstrainedExecution;
// using Microsoft.VisualBasic;

// string studentName = "Sophia Johnson";

// string[] courseName = new string[] { "English", "Algebra", "Biology", "Computer", "Psychology" };
// int[] courseGrade = new int[] { 4, 3, 3, 3, 4 };
// int[] courseCredit = new int[] { 3, 3, 4, 4, 3 };
// double[] courseHours = new double[] { 48.4, 38.4, 38.4, 38.4, 48.4 };
// print($"Student: {studentName}");

// print("Course\t\tGrade\tCredit\tHours");
// print($"{courseName[0]}\t\t{courseGrade[0]}\t{courseCredit[0]}\t{courseHours[0]}");
// print($"{courseName[1]}\t\t{courseGrade[1]}\t{courseCredit[1]}\t{courseHours[1]}");
// print($"{courseName[2]}\t\t{courseGrade[2]}\t{courseCredit[2]}\t{courseHours[2]}");
// print($"{courseName[3]}\t{courseGrade[3]}\t{courseCredit[3]}\t{courseHours[3]}");
// print($"{courseName[4]}\t{courseGrade[4]}\t{courseCredit[4]}\t{courseHours[4]}");
// print("├------------------------------------├");
// print($"|GPA \t\t\t\t{gpa()}|");
// print("├------------------------------------├");
// string gpaMessage = $"\nGPA\t\t\t\t{gpa()}";
// Console.WriteLine(gpaMessage.Length);

// void print(string message)
// {
//     Console.WriteLine(message);
// }
// double gpa()
// {
//     //Calculating Final Grade
//     int[] FinalGrade = new int[courseGrade.Length];
//     double GPA = 0;
//     double Grade = 0;
//     double Credit = 0;

//     for (int i = 0; i < courseGrade.Length; i++)
//     {
//         int grade = courseGrade[i];
//         int credit = courseCredit[i];
//         FinalGrade[i] = grade * credit;
//     }
//     //Grade calculation
//     foreach (int TotalGrade in FinalGrade)
//     {
//         Grade += TotalGrade;
//     }
//     //credit calculation
//     foreach (int TotalCredit in courseCredit)
//     {
//         Credit += TotalCredit;
//     }
//     GPA = Math.Round(Grade / Credit, 2);
//     return GPA;
// }

