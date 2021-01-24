using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            // Test code
            Instructor currInst = new Instructor()
            {
                FullName = "Bart Simpson",
                Email = "bart.simpson@cptc.edu"
            };

            Student stu1 = new Student()
            {
                FirstName = "Lisa",
                LastName = "Simpson"
            };

            Student stu2 = new Student()
            {
                FirstName = "Maggie",
                LastName = "Simpson"
            };

            Student stu3 = new Student()
            {
                FirstName = "Ned",
                LastName = "Flanders"
            };

            Course cpw212 = new Course()
            {
                Title = "CPW 212 - Adv .NET",
                Description = "More .Net than you knew :)",
                Credits = 5,
                CourseInstructor = currInst,
                StudentRoster = new List<Student>()
            };
            cpw212.StudentRoster.Add(stu1);
            cpw212.StudentRoster.Add(stu2);
            cpw212.StudentRoster.Add(stu3);

            Console.WriteLine(cpw212.Title);
            Console.WriteLine("Taught by: " + cpw212.CourseInstructor.FullName);
            Console.WriteLine("Currently Enrolled Students: ");
            foreach (Student student in cpw212.StudentRoster)
            {
                Console.WriteLine(student.ToString());
            }
            Console.ReadKey();
        }
    }
}
