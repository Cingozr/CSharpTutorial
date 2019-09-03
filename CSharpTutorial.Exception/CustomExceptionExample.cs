using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace CSharpTutorial.ExceptionExample
{

    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
    }


    public class CustomExceptionExample : SystemException
    {
        public CustomExceptionExample()
        {

        }

        public CustomExceptionExample(string name) : base($"Invalid Name{name}")
        {

        }

        
    }
}
