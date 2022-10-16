using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Customer : Person
    {
        private string? numberCreditCard;
        public string? NumberCreditCard { get { return numberCreditCard; } set { numberCreditCard = value; } }
        private int moneyOnCreditCard;
        public int MoneyOnCreditCard { get { return moneyOnCreditCard; } set { moneyOnCreditCard = value; } }
        private double drivingExperience;
        public double DrivingeExperience { get { return drivingExperience; } set { drivingExperience = value; } }
        private uint cash;
        public uint Cash { get { return cash; } set { cash = value; } }
        public Customer(string? fullName, string? gender, ushort age, string? numberCreditCard, int moneyOnCreditCard, double drivingExperience, uint cash) : base(fullName, gender, age)
        {
            this.FullName = fullName;
            this.Gender = gender;
            this.Age = age;
            this.NumberCreditCard = numberCreditCard;
            this.MoneyOnCreditCard = moneyOnCreditCard;
            this.DrivingeExperience = drivingExperience;
            this.Cash = cash;
        }

        public void Return(Car c, Administrator a)
        {

            moneyOnCreditCard = moneyOnCreditCard - (c.Price * a.RentalDuration2());
            int f = c.Price * a.RentalDuration2();
            Console.WriteLine($"С вашей карты снято {f}");
            Console.WriteLine($"На вашем счету осталось {moneyOnCreditCard}");
            c.Availability = true;
        }
    }
}
