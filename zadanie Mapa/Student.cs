using System;
using System.Collections.Generic;
using System.Text;

namespace zadanie_Mapa
{
    class Student
    {
        private string firstName;
        private string lastName;
        private int birthYear;
        private int grade;

        public Student(string firstName, string lastName, int birthYear, int grade)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.birthYear = birthYear;
            this.grade = grade;
        }

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public int BirthYear { get => birthYear; set => birthYear = value; }
        public int Grade { get => grade; set => grade = value; }

        public override string ToString()
        {
            return $"{firstName} {lastName} {birthYear} {grade}";
            
        }
    }
}
