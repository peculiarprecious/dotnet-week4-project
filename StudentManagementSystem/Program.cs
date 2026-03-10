// See https://aka.ms/new-console-template for more information
//Student Management System

var studentlist = new[]
{
    new { ID= 1, Name = "Precious", Score = (double?)95.3, IsEnrolled = (bool?)true },
    new { ID= 2, Name = "Joy",   Score = (double?)79.8, IsEnrolled = (bool?)true },
    new { ID= 3,Name = "Sandra",  Score = (double?)59.5, IsEnrolled = (bool?)false },
    new { ID= 4,Name = "Sone", Score = (double?)null, IsEnrolled = (bool?)null },
    new { ID= 5,Name = "Blessing", Score = (double?)null, IsEnrolled = (bool?)null }
} ;

int numberOfStudent = studentlist.Length;
Console.WriteLine($"Number of Student: {numberOfStudent}");

foreach (var student in studentlist)
{
    string scorevalue = student.Score.HasValue ? student.Score.Value.ToString(): "N/A";
    string studentStatus = student.IsEnrolled.HasValue 
    ? (student.IsEnrolled.Value ? "Enrolled" : "Not Enrolled") : "Pending";    // If IsEnrolled is null, it will display "Pending"
    Console.WriteLine($"Student ID: {student.ID}, Student Name: {student.Name}, Score: {scorevalue}, Status:  {studentStatus}  ");
}
