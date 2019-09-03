using CSharpTutorial.ExceptionExample;
using System;
using System.Text.RegularExpressions;

namespace CSharpTutorial.Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student;

            try
            {
                student = new Student();
                student.StudentName = "Recai 01";
                ValideStudentName(student);
            }
            catch (CustomExceptionExample ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public static void ValideStudentName(Student student)
        {
            Regex regex = new Regex("^[a-zA-Z]+$");

            if (!regex.IsMatch(student.StudentName))
                throw new CustomExceptionExample()
        }
    }
}
