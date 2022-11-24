using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace ConsoleApp1
{ [Serializable]
    internal class Customer : Person, ISerializable 
    {
        private string? numberCreditCard;
        public string? NumberCreditCard { get { return numberCreditCard; } set { numberCreditCard = value; } }
        private int moneyOnCreditCard;
        public int MoneyOnCreditCard { get { return moneyOnCreditCard; } set { moneyOnCreditCard = value; } }
        private double drivingExperience;
        public double DrivingExperience { get { return drivingExperience; } set { drivingExperience = value; } }
        private int cash;
        public int Cash { get { return cash; } set { cash = value; } }
        public Customer(string? fullName, string? gender, int age, string? numberCreditCard, int moneyOnCreditCard, double drivingExperience, int cash) 
        {
            this.FullName = fullName;
            this.Gender = gender;
            this.Age = age;
            this.NumberCreditCard = numberCreditCard;
            this.MoneyOnCreditCard = moneyOnCreditCard;
            this.DrivingExperience = drivingExperience;
            this.Cash = cash;
        }
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("FN", FullName, typeof(string));
            info.AddValue("GR", Gender, typeof(string));
            info.AddValue("AGE", Age, typeof(int));
            info.AddValue("NCC", NumberCreditCard, typeof(string));
            info.AddValue("MOCC", MoneyOnCreditCard, typeof(int));
            info.AddValue("DE", DrivingExperience, typeof(double));
            info.AddValue("C", Cash, typeof(int));

        }
        public Customer(SerializationInfo info, StreamingContext context)
        {
            FullName = (string)info.GetValue("FN", typeof(string));
            Gender = (string)info.GetValue("GR", typeof(string));
            Age = (int)info.GetValue("AGE", typeof(int));
            NumberCreditCard = (string)info.GetValue("NCC", typeof(string));
            MoneyOnCreditCard = (int)info.GetValue("MOCC", typeof(int));
            DrivingExperience = (double)info.GetValue("DE", typeof(double));
            Cash = (int)info.GetValue("C", typeof(int));

        }
        public bool Limitation()
        {
            if (DrivingExperience > 1) return true;
            else return false;  
        }


    }
}
