using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_StudentCourse
{
    class Program
    {
        static void Main(string[] args)
        {
             //Student
            Student s0 = new Student("ARNAB", "111", 3.0F);
            Student s1 = new Student("ARNAB SAHA", "112", 3.41F);
            Student s2 = new Student("ARNAB SAHA", "113", 3.23F);
            Student s3 = new Student("ARNAB SAHA", "114", 3.55F);
            Student s4 = new Student("ARNAB SAHA", "115", 3.45F);
            Student s5 = new Student("ARNAB SAHA", "116", 3.22F);
            Student s6 = new Student("ARNAB SAHA", "117", 3.67F);
           
              
            //Course

            Course c1 = new Course("CSC101", "OOAD");
            Course c2 = new Course("CSC102", "TOC");
            Course c3 = new Course("CSC103", "OS");


            //method calling
            c1.AddStudent(s1, s3, s4, s5, s6);

            c1.PrintStudent();

            c1.RemoveStudent(s5);

            Console.WriteLine("\nAfter Remove Student..................\n");

            s5.PrintCourse();
            c1.PrintStudent();

            Console.WriteLine("\n.............................\n");

            s2.AddCourse(c1, c2, c3);
            s2.PrintCourse();

            s2.RemoveCourse(c2);
            Console.WriteLine("\nAfter Remove Course..................\n");
            s2.PrintCourse();
            c2.PrintStudent();
        }
    }
}
