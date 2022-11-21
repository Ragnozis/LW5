using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    [Serializable]
    internal class Treaty
    {
        public delegate void d1(string c);
        private static void Message(string c)
        {
            Console.WriteLine(c);
        }
        d1 Work = new(Message);

        private Administrator? administrator;
        public Administrator? Administrator { get { return administrator; } set { administrator = value; } }
        private Customer? customer;
        public Customer? Customer { get { return customer; } set { customer = value; } }

        private Car? car;
        public Car? Car { get { return car; } set { car = value; } }

        private RentalPoint? rentalPoint;
        public RentalPoint? RentalPoint { get { return rentalPoint; } set { rentalPoint = value; } }
        private int rentalDuration;
        public int RentalDuration { get { return rentalDuration; } set { rentalDuration = value; } }
        public Treaty(Administrator? administrator, Customer? customer, Car? car, RentalPoint? rentalPoint, int rentalDuration)
        {
            this.Administrator = administrator;
            this.Customer = customer;
            this.Car = car;
            this.RentalPoint = rentalPoint;
            this.RentalDuration = rentalDuration;

        }


        public void CompleteRentalProcess()
        {
            string cd = "Введите способ залога: 1 - залог наличными; 2 - залог через кредитную карту";
            Work(cd);
            int f = car.Price * rentalDuration;
            int x = Convert.ToInt32(Console.ReadLine());
            string? number;
            if (x == 1)
            {

                if (customer.Cash > car.Price * rentalDuration)
                {

                    customer.Cash = customer.Cash - f;
                    cd = $"Залог будет составлять {f} рублей";
                    Work(cd);
                    cd = $"Осталось наличными {customer.Cash} рублей";
                    Work(cd);
                }
                else
                {
                    cd = "Не хватает наличных для оплаты залога, оставьте номер вашей кредитной карты";
                    Work(cd);
                    customer.MoneyOnCreditCard = customer.MoneyOnCreditCard - f;
                    cd = $"Залог будет составлять {f} рублей";
                    Work(cd);
                    cd = $"На вашей карте останется {customer.MoneyOnCreditCard}";
                    Work(cd);

                }
            }
            if (x == 2)
            {
                cd = "Оставьте номер вашей кредитной карты";
                Work(cd);
                customer.MoneyOnCreditCard = customer.MoneyOnCreditCard - f;
                cd = $"Залог будет составлять {f} рублей";
                Work(cd);
                cd = $"На вашей карте останется {customer.MoneyOnCreditCard}";
                Work(cd);
            }
        }


    }
}

