using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareAcademy
{
    public class Course
    {
		private string courseName;

		public string CourseName
		{
			get { return courseName; }
			set { courseName = value; }
		}

		private string email;

		public string Email
		{
			get { return email; }
			set { email = value; }
		}

        private List<Student> students = new List<Student>();

        public List<Student> Students { get; set; }

        public Course(string courseName, string email)
        {
            this.CourseName = courseName;
            this.Email = email;
            Students = new List<Student>();
        }

        public void AddStudent(Student student)
        {
            Students.Add(student);
        }

    }
}
