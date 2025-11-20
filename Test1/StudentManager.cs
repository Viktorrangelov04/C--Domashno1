using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    internal class StudentManager
    {
        private List<Student> students = new List<Student>();

        public void AddStudent(Student s)
        {
            students.Add(s);
        }

        public List<Student> GetAllStudents()
        {
            return students; //принтира студентите
        }

        public void RemoveStudent(int index)
        {
            if (index >= 0 && index < students.Count)
                students.RemoveAt(index);// премахва студент от листа по индекс
        }
    }
}
