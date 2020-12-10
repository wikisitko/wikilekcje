using System;
using System.Collections.Generic;
using System.Text;

namespace zadanie_Mapa
{
    class Class
    {
        private List<Student> students;

        public Class()
        {
            this.students = new List<Student>();
        }

        public void Add(string firstName, string lastName, int birthYear, int grade)
        {
            Student s1 = new Student(firstName, lastName, birthYear, grade);
            students.Add(s1);
        }

        
        public override string ToString()
        {
            string s = "";
            for (int i = 0; i < students.Count; i++)
            {
                s += students[i];
            }
            return s;
        }
    }
}
