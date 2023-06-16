using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareAcademy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter academy name:");
            string academyName = Console.ReadLine();

            Academy academy = new Academy(academyName);

            while (true)
            {
                Console.WriteLine("Select option:");
                Console.WriteLine("1. Create Course");
                Console.WriteLine("2. Create Student");
                Console.WriteLine("3. Enroll Student To Course");
                Console.WriteLine("4. Get Student Data");
                Console.WriteLine("5. Print Academy Data");
                Console.WriteLine("6. Exit");

                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Console.WriteLine("Enter course name:");
                        string courseName = Console.ReadLine();
                        Console.WriteLine("Enter course email:");
                        string courseEmail = Console.ReadLine();

                        Course course = new Course(courseName, courseEmail);
                        academy.AddCourse(course);
                        Console.WriteLine("Course successfully created!");
                        break;
                    case 2:
                        Console.WriteLine("Enter student name:");
                        string studentName = Console.ReadLine();

                        Student student = new Student(studentName);
                        academy.AddStudent(student);
                        Console.WriteLine("Student successfully created!");
                        break;
                    case 3:
                        Console.WriteLine("Enter student number:");
                        int studentNumberToEnroll = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter course name:");
                        string courseNameToEnroll = Console.ReadLine();

                        Student studentToEnroll = academy.Students.Find(s => s.Number == studentNumberToEnroll);
                        Course courseToEnroll = academy.Courses.Find(c => c.CourseName == courseNameToEnroll);
                        studentToEnroll.EnrollCourse(courseToEnroll);
                        Console.WriteLine("Student successfully enrolled to course!");
                        break;
                    case 4:
                        Console.WriteLine("Enter student number:");
                        int studentNumberToGet = int.Parse(Console.ReadLine());
                        Student studentToGet = academy.Students.Find(s => s.Number == studentNumberToGet);
                        Console.WriteLine($"Student Number: {studentToGet.Number}");
                        Console.WriteLine($"Name: {studentToGet.Name}");
                        Console.WriteLine("Courses:");
                        foreach (Course courseToGet in studentToGet.Courses)
                        {
                            Console.WriteLine($"Course Name: {courseToGet.CourseName}");
                            Console.WriteLine($"Course Email: {courseToGet.Email}");
                        }
                        break;
                    case 5:
                        academy.PrintAcademyData();
                        break;
                    case 6:
                        break;
                    default:
                        Console.WriteLine("Invalid option!");
                        break;
                }
                Console.WriteLine("Press any key to continue!");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}

