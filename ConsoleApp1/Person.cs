using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal abstract class Person
    { 
        private string? fullName;
        public string? FullName { get { return fullName; } set { fullName = value; } }
        private string? gender;
        public string? Gender { get { return gender; } set { gender = value; } }
        private int age;
        public int Age { get { return age; } set { age = value; } }
       
    }
}
