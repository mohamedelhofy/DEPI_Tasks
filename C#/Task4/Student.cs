using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Student
    {
        private string _name = String.Empty;
        private int _age;
        private string _department = String.Empty;
        private double _gpa;
        public Student(string name, int age, string department, double gpa)
        {
            Name = name;
            Age = age;
            Department = department;
            GPA = gpa;
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }
        public string Department
        {
            get { return _department; }
            set { _department = value; }
        }
        public double GPA
        {
            get { return _gpa; }
            set { _gpa = value; }
        }
        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}, Department: {Department}, GPA: {GPA}";
        }

    }
}
