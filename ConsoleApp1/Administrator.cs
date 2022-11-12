using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Administrator : Person // посмотреть внимательно на методы
    {
        public Administrator(string? fullName, string? gender, ushort age) 
        {
            this.FullName = fullName;
            this.Gender = gender;
            this.Age = age;
        }
       
       


    }
}
