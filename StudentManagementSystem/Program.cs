// See https://aka.ms/new-console-template for more information
//Student Management System

// Data Storage using Lists
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

            if (string.IsNullOrWhiteSpace(studentName)) //String Validation: Name cannot be empty
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
            
            // 1. Print the Header with specific spacing
    Console.WriteLine($"{"ID", -5} {"Name", -18} {"Score", -8} {"Grade", -8} {"Status", -8}");
    Console.WriteLine(new string('-', 50)); // Prints a dashed line

            for (int i = 0; i < studentIDs.Count; i++)

            // 2. Align each column to match the header
        // ID (5 spaces), Name (18 spaces), Score (8 spaces), Grade (8), Status (8)
            {
        Console.WriteLine($"{studentIDs[i], -5} {studentNames[i], -18} {studentScores[i], -8:F1} {Status[i], -8} {gradeStatus[i], -8}");
            }
            break;
        //Calculate Average grade
        case 3:
            Console.WriteLine("\n--- Calculating Average Grade ---");
            double sum = 0;

            foreach (double score in studentScores) // To read out every score in the score list
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
            for (int i = 0; i < studentIDs.Count; i++) //To find a match at index[i]
            {
                if (studentIDs[i] == inputStudentID)
                {
                    Console.WriteLine("\n--- Student Found! ---");
                    Console.WriteLine($"ID: {studentIDs[i]}");
                    Console.WriteLine($"Name: {studentNames[i]}");
                    Console.WriteLine($"Score: {studentScores[i]}");
                    Console.WriteLine($"Grade: {Status[i]}");
                    Console.WriteLine($"Status: {gradeStatus[i]}");

                    found = true;
                    break;
                }

            }
            if (!found)
            {
                Console.WriteLine("Student not found");
            }


            break;
        //Update student score by ID
        case 5:
            Console.WriteLine("\n--- Update student score by ID ---");
            Console.Write("Enter Student ID: ");

            if (!int.TryParse(Console.ReadLine(), out int inputStudentID1) || inputStudentID1 <= 0)
            {
                Console.WriteLine("Error: ID must be a positive number.");
                break;

            }

            bool found1 = false;
            for (int i = 0; i < studentIDs.Count; i++) //To find a match at index[i]
            {
                if (studentIDs[i] == inputStudentID1)
                {


                    Console.Write("Enter Student Score (0-100): ");
                    if (!double.TryParse(Console.ReadLine(), out double studentScore1) || studentScore1 < 0 || studentScore1 > 100)
                    {
                        Console.WriteLine("Error: Score must be a number between 0 and 100.");
                        break;
                    }
                    char statusInput1;
                    string gradestatus2 = (studentScore1 > 40) ? "Pass" : "Fail";
                    if (studentScore1 >= 70)
                    {
                        statusInput1 = 'A';

                    }
                    else if (studentScore1 >= 60) // If it's 60 to 69
                    {
                        statusInput1 = 'B';
                    }
                    else if (studentScore1 >= 50) // If it's 50 to 59
                    {
                        statusInput1 = 'C';
                    }
                    else if (studentScore1 >= 45) // If it's 45 to 49
                    {
                        statusInput1 = 'D';
                    }
                    else if (studentScore1 >= 40) // If it's 40 to 44
                    {
                        statusInput1 = 'E';
                    }
                    else // Anything below 40
                    {
                        statusInput1 = 'F';
                    }


                    studentScores[i] = studentScore1;
                    Status[i] = statusInput1;
                    gradeStatus[i] = gradestatus2;

                    Console.WriteLine($"\nUpdate successful: Student '{studentNames[i]}' (Student ID: {studentIDs[i]}) added with score {studentScores[i]}, Grade: {Status[i]} , Status: {gradeStatus[i]}.");

                    found1 = true;
                    break;
                }

            }
            if (!found1)
            {
                Console.WriteLine("Student not found");
            }
            break;

        //Delete student record by ID
        case 6:
            Console.WriteLine("\n--- Delete student record by ID ---");
            Console.Write("Enter Student ID: ");

            if (!int.TryParse(Console.ReadLine(), out int inputStudentID2) || inputStudentID2 <= 0)
            {
                Console.WriteLine("Error: ID must be a positive number.");
                break;

            }

            bool found2 = false;

            for (int i = 0; i < studentIDs.Count; i++) //To find a match at index[i]
            {
                if (studentIDs[i] == inputStudentID2)
                {

                    string deletedName = studentNames[i];

                    // Remove the record from list at index [i]
                    studentIDs.RemoveAt(i);
                    studentNames.RemoveAt(i);
                    studentScores.RemoveAt(i);
                    Status.RemoveAt(i);
                    gradeStatus.RemoveAt(i);

                    Console.WriteLine($"\nSUCCESS: Record for '{deletedName}' has been deleted.");

                    found2 = true;
                    break;
                }
            }

            if (!found2)
            {
                Console.WriteLine("Student not found");
            }
            break;
        //Display Statistics
        case 7:

            if (studentScores.Count > 0)

            {
                int passCount = 0;
                int failCount = 0;
                double totalScore = 0;
                double minScore = studentScores.Min();
                double maxScore = studentScores.Max();
                double averageScore = studentScores.Average();

                foreach (double score in studentScores) // To read out every score in the score list
                {
                    if (score >= 60)
                    {
                        passCount++;
                    }
                    else
                    {
                        failCount++;
                    }

                    totalScore +=score;
                }

                Console.WriteLine("\n--- Display Statistics ---");
                Console.WriteLine($"Total Students: {studentScores.Count}");
                Console.WriteLine($"Highest Score: {maxScore}");
                Console.WriteLine($"Lowest Score: {minScore}");
                Console.WriteLine($"Class Average: {averageScore:F2}");
                Console.WriteLine($"Passing Students (>=60): {passCount}");
                Console.WriteLine($"Failing Students (<60):  {failCount}");
                Console.WriteLine($"Total Score:  {totalScore}");
            }
            else
            {
                Console.WriteLine("No data available to display statistics.");
            }

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
