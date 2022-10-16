using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Treaty
    {

        public bool Check(Customer ct)
        {
            if (ct.DrivingeExperience > 1) return true;
            else return false;
        }
        public void Return(Customer ct, Car c, Administrator a)
        { ct.Return(c, a); }
        public void Create(Customer ct, RentalPoint r, Administrator a, Car c)
        {
            Console.WriteLine($"Администратор {a.FullName} будет оформлять сделку {ct.FullName}");
            a.Pledge(ct);
            a.RentalDuration1();
            a.Availability(c);

        }
    }
}

