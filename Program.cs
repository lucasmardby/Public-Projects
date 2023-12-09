using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Globalization;
using System.IO.Enumeration;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;
using System.Security.Cryptography.X509Certificates;

namespace First_Repository
{
    class Program
    {
        static void Main(string[] args)
        {
            var student1 = new Student("Sophia", 93, 87, 98, 95, 100);
            var student2 = new Student("Nicolas", 80, 83, 82, 88, 85);
            var student3 = new Student("Zahirah", 84, 96, 73, 85, 79);
            var student4 = new Student("Jeong", 90, 92, 98, 100, 97);
            var student5 = new Student("Lucas", 100, 60, 60, 60, 60);

            Console.WriteLine("Student\t\tGrade\n");
            Console.WriteLine($"{student1.Name}{student1.FirstSpacing()}{student1.Score}\t{student1.Grading()}");
            Console.WriteLine($"{student2.Name}{student2.FirstSpacing()}{student2.Score}\t{student2.Grading()}");
            Console.WriteLine($"{student3.Name}{student3.FirstSpacing()}{student3.Score}\t{student3.Grading()}");
            Console.WriteLine($"{student4.Name}{student4.FirstSpacing()}{student4.Score}\t{student4.Grading()}");
            Console.WriteLine($"{student5.Name}{student5.FirstSpacing()}{student5.Score}\t{student5.Grading()}");

        }

    }

}
