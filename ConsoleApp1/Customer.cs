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
        public Customer(string? fullName, string? gender, ushort age, string? numberCreditCard, int moneyOnCreditCard, double drivingExperience, int cash) 
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
            // Use the AddValue method to specify serialized values.
            info.AddValue("props", FullName, typeof(string));
            
            

        }
        public Customer(SerializationInfo info, StreamingContext context)
        {
            // Reset the property value using the GetValue method.
            FullName = (string)info.GetValue("props", typeof(string));

        }
        public bool Limitation()
        {
            if (DrivingExperience > 1) return true;
            else return false;  
        }


    }
}
