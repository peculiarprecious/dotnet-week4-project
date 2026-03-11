// See https://aka.ms/new-console-template for more information
//Student Management System

List<int> studentIDs = new List<int> { 1, 2, 3, 4, 5 };
List<string> studentNames = new List<string> { "David Ayeni", "Joy Osaghae", "Sandra Ike", "Sone Adibeli", "Blessing Okafor" };
List<double> studentScores = new double[] { 95.3, 60.8, 59.5, 45.0, 30.0 }.ToList();
List<char> Status = new List<Char> { 'A', 'B', 'C', 'D', 'F' };
List<string> gradeStatus = new List<string> { "Pass", "Pass", "Pass", "Pass", "Fail" };


bool IsActiveMenu = true;

while (IsActiveMenu)
{
    Console.WriteLine("\nChoose a Menu:");
    Console.WriteLine("1. Add new student");
    Console.WriteLine("2. View all students");
    Console.WriteLine("3. Calculate average grade");
    Console.WriteLine("4. Find student by ID");
    Console.WriteLine("5. Update student grade");
    Console.WriteLine("6. Delete student");
    Console.WriteLine("7. Display statistics");
    Console.WriteLine("8. Exit");
    Console.Write("Enter your choice: ");

    string? input = Console.ReadLine();
    bool isValidInt = int.TryParse(input, out int userInput);

    switch (userInput)
    {   // Add New Student
        case 1:
            Console.WriteLine("\n--- Add New Student ---");

            int nextID = studentIDs.Count + 1; // Automatic StudentID to follow the order, instead of prompting the user to enter it
            Console.Write("Enter Student Name: ");

            string? studentName = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(studentName))
            {
                Console.WriteLine("Error: Name cannot be empty.");
                break;
            }
            // 3. Validate Score (Must be double between 0-100)
            Console.Write("Enter Student Score (0-100): ");
            if (!double.TryParse(Console.ReadLine(), out double studentScore) || studentScore < 0 || studentScore > 100)
            {
                Console.WriteLine("Error: Score must be a number between 0 and 100.");
                break;
            }

            char statusInput;
            string gradestatus1 = (studentScore > 40) ? "Pass" : "Fail";
            if (studentScore >= 70)
            {
                statusInput = 'A';
                gradestatus1 = "Pass";
            }
            else if (studentScore >= 60) // If it's 60 to 69
            {
                statusInput = 'B';
            }
            else if (studentScore >= 50) // If it's 50 to 59
            {
                statusInput = 'C';
            }
            else if (studentScore >= 45) // If it's 45 to 49
            {
                statusInput = 'D';
            }
            else if (studentScore >= 40) // If it's 40 to 44
            {
                statusInput = 'E';
            }
            else // Anything below 40
            {
                statusInput = 'F';
            }

            //ADD to the lists
            studentIDs.Add(nextID);
            studentNames.Add(studentName);
            studentScores.Add(studentScore);
            Status.Add(statusInput);
            gradeStatus.Add(gradestatus1);

            // 4. Confirm Success
            Console.WriteLine($"\nSUCCESS: Student '{studentName}' (Student ID: {nextID}) added with score {studentScore}, Grade: {statusInput} , Status: {gradestatus1}.");
            break;

        //View All Students
        case 2:
            Console.WriteLine("\n--- Student List ---");

            for (int i = 0; i < studentIDs.Count; i++)
            {
                Console.WriteLine($"ID: {studentIDs[i]}, Name: {studentNames[i]}, Score: {studentScores[i]}, Grade: {Status[i]}, Status: {gradeStatus[i]} ");
            }
            break;
        //Calculate Average grade
        case 3:
            Console.WriteLine("\n--- Calculating Average Grade ---");
            double sum = 0;

            foreach (double score in studentScores)
            {
                sum += score;
            }
            if (studentScores.Count > 0)
            {
                double average = sum / studentScores.Count;
                Console.WriteLine($"The average grade for {studentIDs.Count} students is: {average:F2}");
            }
            else
            {
                Console.WriteLine("No students in the system.");
            }

            break;
        //Find Student by ID
        case 4:
            Console.WriteLine("\n--- Find Student by ID ---");
            Console.Write("Enter Student ID: ");

            if (!int.TryParse(Console.ReadLine(), out int inputStudentID) || inputStudentID <= 0)
            {
                Console.WriteLine("Error: ID must be a positive number.");
                break;

            }

            bool found = false;
            for (int i = 0; i < studentIDs.Count; i++)
            {
                if (studentIDs[i] == inputStudentID)
                {
                    Console.WriteLine("\n--- Student Found! ---");
                    Console.WriteLine($"ID: {studentIDs[i]}");
                    Console.WriteLine($"Name: {studentNames[i]}");
                    Console.WriteLine($"Score: {studentScores[i]}");
                    Console.WriteLine($"Status: {Status[i]}");

                    found = true;
                    break;
                }

            }
            if (!found)
            {
                Console.WriteLine("Student not found");
            }


            break;
        case 5:

            break;
        case 6:

            break;
        case 7:

            break;
        case 8:
            IsActiveMenu = false;
            Console.WriteLine("Exiting program...");
            break;

        default:
            Console.WriteLine("Invalid selection, please try again.");
            break;
    }



}
