using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{
    public class Course
    {
        private int courseID;
        private string title;
        private Dictionary<Student, Double> _listStudent;
        public event Action<int, int> OnNumberOfStudentChange;

        public Course(int Course,string title)
        {
            this.courseID = Course;
            this.title = title;
            this._listStudent = new Dictionary<Student, double>();
        }

        public int CourseId
        {
            get => this.courseID;
            set => this.courseID = value;
        }
        public string Title
        {
            get => this.title;
            set => this.title = value;
        }

        public void AddStudent(Student student, Double Gpa)
        {
            int oldNum = _listStudent.Count;
            _listStudent.Add(student, Gpa);
            int newNum = _listStudent.Count;
            OnNumberOfStudentChange?.Invoke(oldNum, newNum);
        }

        public void RemoveStudent(int studentID)
        {
            int oldNum = this._listStudent.Count;
            Student studentDelete = null;
            foreach (var s in _listStudent.Keys)
            {
                if (s.StudentID == studentID)
                {
                    studentDelete = s;
                }
            }
            int newNum = this._listStudent.Count -1;
            OnNumberOfStudentChange?.Invoke(oldNum,newNum);
            _listStudent.Remove(studentDelete);
        }

        public override string ToString()
        {
            string output = $"Course: {courseID} - {Title}\n";
            foreach (var s in _listStudent)
            {
                output += $"Student: {s.Key.StudentID} - {s.Key.StudentName} - {s.Value}\n";
            }
            return output ;
        }
    }
}
