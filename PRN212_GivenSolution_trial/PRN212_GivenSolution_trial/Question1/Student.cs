using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{
    public class Student
    {
        private int studentID;
        private string studentName;

        public Student() { }
        public Student(int studentID,String studentName)
        {
            this.studentID = studentID;
            this.studentName = studentName;
        }

        public int StudentID 
        {  
            get=> studentID; 
            set =>studentID = value; 
        }

        public string StudentName
        {
            get => studentName;
            set => studentName = value;
        }

    }
}
