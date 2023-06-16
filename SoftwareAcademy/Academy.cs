using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareAcademy
{
    internal class Academy
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private List<Course> courses = new List<Course>();

        public List<Course> Courses { get; set; }

        private List<Student> students = new List<Student>();

        public List<Student> Students { get; set; }

        public Academy(string name)
        {
            this.Name = name;
            Courses = new List<Course>();
            Students = new List<Student>();
        }

        public void AddCourse(Course course)
        {
            Courses.Add(course);
        }

        public void AddStudent(Student student)
        {
            Students.Add(student);
        }

        public void PrintAcademyData()
        {
            Console.WriteLine($"Academy: {Name}");
            Console.WriteLine("Students:");

            foreach (var student in Students)
            {
                Console.WriteLine($"Student ID: {student.Number}");
                Console.WriteLine($"Name: {student.Name}");
                Console.WriteLine("Courses:");

                foreach (var course in student.Courses)
                {
                    Console.WriteLine($"- {course.CourseName}");
                }

                Console.WriteLine();
            }

            Console.WriteLine("Courses without students: ");

            foreach (var course in Courses)
            {
                if (course.Students.Count == 0)
                {
                    Console.WriteLine(course.CourseName);
                }
            }
        }
    }
}
