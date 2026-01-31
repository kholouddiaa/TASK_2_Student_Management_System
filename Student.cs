using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TASK_2___Student_Management_System
{
    internal class Student
    {
        public int Id;
        public string Name;
        public string Email;
        public int Grade;
        double GPA;
        public Student(int id, string name, string email, int grade)
        { if ( !email.Contains("@"))
            {
                throw new ArgumentException("Invalid email format");
            }


            if (grade < 0 || grade > 100)
            {
                throw new ArgumentException("Grade must be between 0 and 100");
            }
                 
                    Id = id;
                    Name = name;
                    Email = email;
                    Grade = grade;
         }

            
       


        public void SetGrade(int grade)
        {
            if (grade <0 || grade > 100)
            {
                throw new ArgumentException("Grade must be between 0 and 100");
            }
            Grade = grade;
        }
        public double GetGPA(int grade)
        {
            if (grade >= 90)
            {
                GPA = 4.0;
            }
            else if (grade >= 80)
            {
                GPA = 3.0;
            }
            else if (grade >= 70)
            {
                GPA = 2.0;
            }
            else if (grade >= 60)
            {
                GPA = 1.0;
            }
            else
            {
                GPA = 0.0;
            }
            return GPA;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Grade: {Grade}");
            Console.WriteLine($"GPA: {GetGPA(Grade)}");
        }

    }
}






    