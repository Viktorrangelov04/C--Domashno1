using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    internal class Student
    {
        public string Name { get; set; }
        public string FacultyNumber { get; set; }
        public string Course { get; set; }

        public Student(string name, string facultyNumber, string course)
        {
            Name = name;
            FacultyNumber = facultyNumber;
            Course = course;
        }

        public override string ToString()
        {
            return $"{Name} ({FacultyNumber}) - {Course}"; // Превръща информацията за студента като низ
        }
    }
}
