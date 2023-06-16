using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareAcademy
{
    public class Student
    {
        private static int number = 1;
        private string name;
        private List<Course> courses = new List<Course>();

        public int Number { get; }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public List<Course> Courses
        {
            get { return courses; }
            set { courses = value; }
        }

        public Student(string name)
        {
            Number = number++;
            this.Name = name;
        }

        public void EnrollCourse(Course course)
        {
            Courses.Add(course);
            course.AddStudent(this);
        }
    }
}

