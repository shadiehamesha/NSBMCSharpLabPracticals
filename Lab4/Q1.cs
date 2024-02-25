//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Lab4
//{
//    public class Course
//    {
//        private string courseName;
//        private string instructorName;
//        private double grade;

//        public string CourseName
//        {
//            get { return courseName; }
//        }

//        public double Grade
//        {
//            get { return grade; }
//        }

//        public void SetInstructorName(string Name)
//        {
//            if (string.IsNullOrEmpty(Name))
//            {
//                throw new ArgumentException("Instructor name cannot be empty or null.");
//            }
//            instructorName = Name;
//        }

//        private string CalculateLetterGrade(double grade)
//        {
//            if (grade >= 70)
//                return "A";
//            else if (grade >= 60)
//                return "B";
//            else if (grade >= 50)
//                return "C";
//            else if (grade >= 40)
//                return "S";
//            else
//                return "F";
//        }

//        public void PrintCourseInfo()
//        {
//            string marks = CalculateLetterGrade(grade);
//            Console.WriteLine("Course: " + courseName);
//            Console.WriteLine("Instructor: " + instructorName);
//            Console.WriteLine("Grade: " + marks);
//        }
//    }
//    class Program
//    {
//        static void Main(string[] args)
//        {
//        }
//    }
//}
