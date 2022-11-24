using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Administrator : Person 
    {
        public Administrator(string? fullName, string? gender, ushort age) 
        {
            this.FullName = fullName;
            this.Gender = gender;
            this.Age = age;
        }
       
       


    }
}
