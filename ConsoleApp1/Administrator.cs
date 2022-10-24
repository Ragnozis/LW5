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
        public void Pledge(Customer ct)
        {

            Console.WriteLine("Введите способ залога: 1 - залог наличными; 2 - залог через кредитную карту");
            int x = Convert.ToInt32(Console.ReadLine());
            string? number;
            if (x == 1)
            {

                if (ct.Cash > 300) { ct.Cash = ct.Cash - 300; Console.WriteLine("Залог будет составлять 300 рублей"); Console.WriteLine($"Осталось наличными {ct.Cash} рублей"); }
                else
                {
                    Console.WriteLine("Не хватает наличных для оплаты залога, оставьте номер вашей кредитной карты");
                    number = ct.NumberCreditCard;
                }
            }
            if (x == 2)
            {
                number = ct.NumberCreditCard;
                Console.WriteLine($"Номер вашей кредитной карты {number}");
            }
        }
        public int RentalDuration1()
        {
            int duration = 5;
            Console.WriteLine($"Продолжительность проката автомобиля {duration} дней ");
            return duration;
        }
        public int RentalDuration2()
        {
            int duration = 5;
            return duration;
        }
        public bool Availability(Car c)
        {
            c.Availability = false;
            return c.Availability;
        }

    }
}
