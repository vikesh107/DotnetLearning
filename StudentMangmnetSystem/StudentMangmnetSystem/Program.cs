using System.ComponentModel.Design;
using System.Diagnostics.Metrics;
using System.Security.Claims;

namespace StudentMangmnetSystem
{
    internal class Program
    {
        static List<Student> students1 = new List<Student>();
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("1. Add Student to system");
                Console.WriteLine("2. Get all students with details");
                Console.WriteLine("3. Filter students");
                Console.WriteLine("4. Find the student(s) whose age is in between 15 to 25.");
                Console.WriteLine("5. Find the topper of the class");
                Console.WriteLine("6. Find the roll no of students in Nth position of topper list");
                Console.WriteLine("7. Find classes every 10 seconds");
                Console.WriteLine("8. Exit");

                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddStudent();
                        break;
                    case "2":
                        GetAllStudents();
                        break;
                    case "3":
                        FilterStudents();
                        break;
                    case "4":
                        FindStudentsByAgeRange();
                        break;
                    case "5":
                        FindClassTopper();
                        break;
                    case "6":
                        FindRollNoInTopperList();
                        break;
                    case "7":
                        FindClassesEvery10Seconds();
                        break;
                    case "8":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        static void AddStudent()
        {
            Console.WriteLine("Enter student details:");

            Console.Write("First Name: ");

            string firstName = Console.ReadLine();

            Console.Write("Middle Name: ");
            string middleName = Console.ReadLine();

            Console.Write("Last Name: ");
            string lastName = Console.ReadLine();

            
            int age;
            Console.Write("Age : ");
            while (true)
            {
                try
                {
                    
                    age = int.Parse(Console.ReadLine());
                    while (age < 0 )
                    {
                        Console.WriteLine("Invalid input. Please Enter The Valid Age :");
                        Console.Write("Age: ");
                        age = int.Parse(Console.ReadLine());
                    }
                    if(age>0 && age < 100)
                    {
                        break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);

                }
                Console.WriteLine("Invalid input. Please Enter The Valid Age : ");
            }

                
            int rollNo;
            Console.Write("Roll No : ");
            while (true)
            {
                try
                {
                    rollNo = int.Parse(Console.ReadLine());
                    while (age < 0)
                    {
                        Console.WriteLine("Invalid input.Please Enter The Roll Number: ");
                        Console.Write("Age: ");
                        rollNo = int.Parse(Console.ReadLine());
                    }
                    if (rollNo > 100 && rollNo < 999)
                    {
                        break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);

                }
                Console.WriteLine("Invalid input. Please Enter The Roll Number : ");
            }

            Console.Write("(Class First for : 1 / Class Second for : 2 / Class Third for : 3/Class Fourth for : 4/Class Fifth for :5) Class : ");
            StudentClass studentClass;
            int classByNumber = int.Parse(Console.ReadLine());          
            while (classByNumber<0 || classByNumber>5)
            {
                Console.WriteLine("Invalid Input. Please Enter The Vlid Class:");
                classByNumber = int.Parse(Console.ReadLine());   
            }
            studentClass = (StudentClass)classByNumber;

            Console.Write("Please Enter The Subject and Seprated by Cooma  :");
            List<string> subjects = Console.ReadLine().Split(',').ToList();
            while (subjects.Count < 0 ||  subjects.Count>5 || String.IsNullOrEmpty(subjects[0].Trim()))
            {
                Console.Write("Please Enter Valid  Subject and Seprated by Cooma  :");
                subjects = Console.ReadLine().Split(',').ToList();
            }
            //Console.WriteLine(subjects.Count);  for count the subject abd print all the iteam of list
            //foreach ( var iteam in subjects)
            //{
            //    Console.WriteLine(iteam);
            //}

            Console.Write("Address: ");
            string address = Console.ReadLine().Trim();
            while (String.IsNullOrEmpty(address))
            {
                Console.Write("Invalid Input, Please enter the valid Address");
                address = Console.ReadLine().Trim();
            }

            Console.Write("Hobbies : ");
            List<string> hobbies = Console.ReadLine().Split(',').ToList();
            while (hobbies.Count < 1 || hobbies.Count >= 7 || String.IsNullOrEmpty(hobbies[0].Trim()))
            {
                
                if (hobbies.Count >= 7)
                {
                    Console.Write("Please Enter Valid Hobbies And add at most 7 hobbies : ");
                }
                else
                {
                    Console.Write("Invalid Input. Please Enter Valid  Hobbies :");
                }
                hobbies = Console.ReadLine().Split(',').ToList();
            }

            Console.WriteLine("Enter marks for each subject:");

            Dictionary<string, int> marks = new Dictionary<string, int>();
            int EveryStuentTotalMark=0;
            foreach (var subject in subjects)
            {
                    Console.Write($"Marks for {subject}: ");
                    int mark;
                //while (!int.TryParse(Console.ReadLine(), out mark) || mark < 0 || mark > 100)
                //{
                //    Console.WriteLine("Invalid input. Please enter a valid mark between 0 and 100.");
                //    Console.Write($"Marks for {subject}: ");
                //}

                while (true)
                {
                    try
                    {

                        mark = int.Parse(Console.ReadLine());
                        while (mark < 0 || mark > 100)
                        {
                            Console.WriteLine("Invalid input. Please enter a valid mark between 0 and 100.");
                            Console.Write($"Marks for {subject}: ");
                            mark = int.Parse(Console.ReadLine());                         
                        }
                        if (mark > 0 && mark < 100)
                        {
                            
                            EveryStuentTotalMark += mark;
                            break;
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);

                    }
                    Console.WriteLine("Invalid input. Please Enter The Valid Mark. ");
                    Console.Write($"Marks for {subject}: ");
                }
                marks.Add(subject, mark);

                
            }


                // Create a new Student object
                Student newStudent = new Student
                {
                    FirstName = firstName,
                    MiddleName = middleName,
                    LastName = lastName,
                    Age = age,
                    RollNo = rollNo,
                    Class = studentClass,
                    Subjects = subjects,
                    Marks = marks,
                    Address = address,
                    Hobbies = hobbies,
                    AddedDateTime = DateTime.Now,
                    TotalMark = EveryStuentTotalMark


                };

                // Add the new student to the list
                students1.Add(newStudent);

                Console.WriteLine("Student added successfully!");
            
        }

            static void GetAllStudents()
            {
                

                if (students1.Count == 0)
                {
                    Console.WriteLine("No students in the system.\n");
                    return;
                }
                Console.WriteLine("\nList of all students:");
                foreach (var student in students1)
                {
                    Console.WriteLine($"----------------------");
                    Console.WriteLine($"Name: {student.FirstName} {student.MiddleName} {student.LastName}");
                    Console.WriteLine($"Age: {student.Age}");
                    Console.WriteLine($"Roll No: {student.RollNo}");
                    Console.WriteLine($"Class: {student.Class}");

                    // Display other properties like Subjects, Marks, Address, Hobbies, etc.
                    if (student.Subjects != null && student.Subjects.Count > 0)
                    {
                        Console.WriteLine($"Subjects: {string.Join(", ", student.Subjects)}");
                    }

                    if (student.Marks != null && student.Marks.Count > 0)
                    {
                        Console.WriteLine("Marks:");
                        foreach (var subject in student.Marks.Keys)
                        {
                            Console.WriteLine($"  {subject}: {student.Marks[subject]}");
                        }
                        //Console.WriteLine("---------------");  aas a squre braket me bhi print karwa sakte hai
                        //foreach(KeyValuePair<String,int> sub in student.Marks)
                        //{
                        //Console.WriteLine(sub);
                        //}
                    }

                    if (!string.IsNullOrEmpty(student.Address))
                    {
                        Console.WriteLine($"Address: {student.Address}");
                    }

                    if (student.Hobbies != null && student.Hobbies.Count > 0)
                    {
                        Console.WriteLine($"Hobbies: {string.Join(", ", student.Hobbies)}");
                    }

                    Console.WriteLine($"Added Date-Time: {student.AddedDateTime}");
                    Console.WriteLine($"Total Marks : {student.TotalMark}" );
                    Console.WriteLine($"----------------------\n");
                }
            }

        static void FilterStudents()
        {
           
            if (students1.Count > 0)
            {

                while (true)
                {
                    //class, subjects, address, hobbies, added date time
                    Console.WriteLine("1. Filter by Full Name ");
                    Console.WriteLine("2. Filter by Class ");
                    Console.WriteLine("3. Filter subjects");
                    Console.WriteLine("4. Filter address");
                    Console.WriteLine("4. Filter hobbies");
                    Console.WriteLine("6. Filter Added date time"); 
                    Console.WriteLine("7. Press 7 For Exit.");
                    Console.Write("Please Enter The Choice : ");
                    int i = int.Parse(Console.ReadLine());
                    switch (i)
                    {
                        case 1:
                            FilterStudentsClass.FilterByName(students1);
                            break;
                        case 2:
                            FilterStudentsClass.FilterByClass(students1);
                            break;
                        case 3:
                            FilterStudentsClass.FilterBySubject(students1);
                            break;
                        case 4:
                            FilterStudentsClass.FilterByAddress(students1);
                            break;
                        case 5:
                            FilterStudentsClass.FilterByHobbies(students1);
                            break;
                        case 6:
                            FilterStudentsClass.FilterByDateAndTime(students1);
                            break;
                        case 7:
                            return;

                    }
                }
            }else { Console.WriteLine("No Student Data Present in System..."); }
        }

            static void FindStudentsByAgeRange()
            {
            
            if (students1.Count <= 0)
            {
                Console.WriteLine("No students in the system.\n");
            }
            else
            {
                int i = 0;
                foreach (Student student in students1)
                {
                    if (student.Age > 15 && student.Age < 25)
                    {
                        FilterStudentsClass ob = new FilterStudentsClass();
                        ob.GetStudent(student);
                        i++;
                    }

                }
                if (i == 0)
                {
                    Console.WriteLine("Not Student Preasnt in System whose age is in between 15 to 25");
                }
            }

            }

            static void FindClassTopper()
            {
            if (students1.Count > 0)
            {
                Console.Write("Class (First_Class 1 /Second_Class 2 /Third_Class 3/Fourth_Class 4/Fifth_Class 5): ");
                int Class = int.Parse(Console.ReadLine());
                int i = 0;
                List<Student> sortedListByMarks = new List<Student>();
                foreach (Student s in students1)
                {
                    if (s.Class == (StudentClass)Class)
                    {
                        sortedListByMarks.Add(s);
                    }
                }
                if (sortedListByMarks.Count > 0)
                {
                    sortedListByMarks.Sort((x, y) => x.TotalMark.CompareTo(y.TotalMark));
                    FilterStudentsClass ob = new FilterStudentsClass();
                    ob.GetStudent(sortedListByMarks[sortedListByMarks.Count - 1]);
                }
                if (i == 0)
                {
                    Console.WriteLine($"No Data Found With Specific Class ");
                }
            }
            else
            {
                Console.WriteLine("No students in the system.\n");
            }

            }

            static void FindRollNoInTopperList()
            {
            if (students1.Count > 0)
            {
                Console.Write("Class (First_Class 1 /Second_Class 2 /Third_Class 3/Fourth_Class 4/Fifth_Class 5): ");
                int Class = int.Parse(Console.ReadLine());
                Console.Write("Enter the position (N) of the topper: ");
                int enterPoition = int.Parse(Console.ReadLine());
                List<Student> sortedListByMarks = new List<Student>();
                foreach (Student s in students1)
                {
                    if (s.Class == (StudentClass)Class)
                    {
                        sortedListByMarks.Add(s);
                    }
                }
                sortedListByMarks.Sort((x, y) => x.TotalMark.CompareTo(y.TotalMark));
                if (enterPoition > 0 && enterPoition <= sortedListByMarks.Count)
                {
                    var nthTopper = sortedListByMarks[(sortedListByMarks.Count - enterPoition)];
                    Console.WriteLine($"Roll No of student at position {enterPoition} in the topper list: {nthTopper.RollNo}");
                }
                else
                {
                    Console.WriteLine("Invalid position. Please enter a valid position.");
                }
            }
            else
            {
                Console.WriteLine("No students in the system.\n");
            }

            }

            static void FindClassesEvery10Seconds()
            {
                if(students1.Count > 0)
                {
                    Thread td = new Thread(Program.Every10sec);
                    td.Start();
                }
                else 
                { 
                    Console.WriteLine("No students in the system.\n");  
                }
            }

            static void Every10sec()
            {
                foreach (Student student in students1)
                {
                    Thread.Sleep(10000);
                    Console.WriteLine($"{student.FirstName} {student.LastName} belongs to {student.Class} class.");
                }

            }

        

    }
    
}
