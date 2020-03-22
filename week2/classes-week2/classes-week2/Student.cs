using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes_week2
{
    class Student
    {
        private int age;
        private string name;
        private int studentID;

        public Student(string inputName, int inputAge, int inputID)
        {
            age = inputAge;
            name = inputName;
            studentID = inputID;
        }
    }
}
