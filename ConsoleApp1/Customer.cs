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
        private int cash;
        public int Cash { get { return cash; } set { cash = value; } }
        public Customer(string? fullName, string? gender, ushort age, string? numberCreditCard, int moneyOnCreditCard, double drivingExperience, int cash) 
        {
            this.FullName = fullName;
            this.Gender = gender;
            this.Age = age;
            this.NumberCreditCard = numberCreditCard;
            this.MoneyOnCreditCard = moneyOnCreditCard;
            this.DrivingeExperience = drivingExperience;
            this.Cash = cash;
        }

      
    }
}
