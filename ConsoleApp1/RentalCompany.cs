using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class RentalCompany
    {
        public delegate void d1(string c);
        private static void Message(string c)
        {
            Console.WriteLine(c);
        }
        public static void SerializeItem(string fileName, IFormatter formatter)
        {
            // Create an instance of the type and serialize it.
            Customer t = new Customer("Смирнова Марина Викторовна", "женщина", 25, "4111111111100031", 5000, 5, 500);

            FileStream s = new FileStream(fileName, FileMode.Create);
            formatter.Serialize(s, t);
            s.Close();
        }

        public static void DeserializeItem(string fileName, IFormatter formatter)
        {
            FileStream s = new FileStream(fileName, FileMode.Open);
            Customer t = (Customer)formatter.Deserialize(s);
            Console.WriteLine(t.FullName);
        }

        static void Main(string[] args)
        {
            Random rnd;
            Customer ct1 = new Customer("Смирнова Марина Викторовна", "женщина", 25, "4111111111100031", 5000, 5, 500);
            Customer ct2 = new Customer("Белов Андрей Федорович", "мужчина", 32, "4111151111100031", 10000, 2, 100);
            Customer ct3 = new Customer("Белая Анастасия Николаевна", "женщина", 20, "4117211111100031", 2000, 0.3, 300);
            Customer ct4 = new Customer("Соболев Алексей Константинович", "мужчина", 40, "4111111143100031", 5000, 12, 1000);
            Administrator a1 = new Administrator("Иванов Петр Сергеевич", "мужчина", 32);
            Administrator a2 = new Administrator("Никитин Вадим Эдуардович", "мужчина", 27);
            Administrator a3 = new Administrator("Артемьев Федор Юлианович", "мужчина", 43);
            Administrator a4 = new Administrator("Овчинников Артур Антонович", "мужчина", 36);
            Administrator a5 = new Administrator("Лапина Лариса Богдановна", "женщина", 23);
            Administrator a6 = new Administrator("Павлова Каролина Федоровна", "женщина", 34);
            Administrator a7 = new Administrator("Родионова Эльвира Андреевна", "женщина", 57);
            Administrator a8 = new Administrator("Панова Ядвига Робертовна", "женщина", 41);
            Car c1 = new Car("Audi", "A6", "8543 AX-4", 125, 198, 1781, 8.6, 70, true, 20);
            Car c2 = new Car("BMW", "M6", "9684 KH-4", 560, 250, 4395, 9.9, 80, true, 80);
            Car c3 = new Car("Honda", "Jazz", "4253 AX-4", 102, 190, 1318, 5, 40, true, 30);
            Car c4 = new Car("Opel", "Adam", "1236 KH-4", 70, 165, 1229, 5, 38, false, 18);
            Car c5 = new Car("Mercedes", "GLA", "9257 AX-4", 700, 345, 5312, 7.6, 74, true, 120);
            Car c6 = new Car("Toyota", "Camry", "2684 KH-4", 486, 305, 3752, 8.9, 57, true, 86);
            Car c7 = new Car("Volkswagen", "Polo", "4195 KH-4", 256, 345, 2000, 5.9, 59, false, 50);
            Car c8 = new Car("Renault", "Megane", "4102 AX-4", 600, 900, 6042, 7.4, 90, true, 160);
            RentalPoint r1 = new RentalPoint("ул. Дзержинского 30", new List<Car>() { c1, c6, c3, c2 }, new List<Administrator>() { a1, a3 });
            RentalPoint r2 = new RentalPoint("ул. Будённого 37", new List<Car>() { c2, c4, c7, c8 }, new List<Administrator>() { a2, a5 });
            RentalPoint r3 = new RentalPoint("ул. Гаспадарчая 29/1", new List<Car>() { c8, c3, c5, c2 }, new List<Administrator>() { a4, a7 });
            RentalPoint r4 = new RentalPoint("Озерское ш. 14", new List<Car>() { c1, c6, c4, c8 }, new List<Administrator>() { a6, a8 });
            List<RentalPoint> RP = new List<RentalPoint>() { r1, r2, r3, r4 };
            List<Customer> customers = new List<Customer>() { ct1, ct2, ct3, ct4 };
            Car[] arrray1 = new Car[r1.C.Count];
            Car[] arrray2 = new Car[r2.C.Count];
            Car[] arrray3 = new Car[r3.C.Count];
            Car[] arrray4 = new Car[r4.C.Count];
            r1.SelectedCar(arrray1);
            r2.SelectedCar(arrray2);
            r3.SelectedCar(arrray3);
            r4.SelectedCar(arrray4);
           /* string fileName = "dataStuff.myData";
            IFormatter formatter = new BinaryFormatter();
            RentalCompany.SerializeItem(fileName, formatter); // Serialize an instance of the class.
            RentalCompany.DeserializeItem(fileName, formatter); // Deserialize the instance.
            Console.WriteLine("Done");
            Console.ReadLine();
           */
            rnd = new Random();
            var selected_customer = customers[rnd.Next(customers.Count)];
            var selected_RentalPoint = RP[rnd.Next(RP.Count)];
            var selected_car = selected_RentalPoint.C[rnd.Next(selected_RentalPoint.C.Count)];
            var selected_administrator = selected_RentalPoint.A[rnd.Next(selected_RentalPoint.A.Count)];
            d1 Work = new(Message);
            string cd = $"{selected_customer.FullName} направляется в прокат на {selected_RentalPoint.Address}";
            Work(cd);
            cd = $"{selected_customer.FullName} хочет взять на прокат {selected_car.Brand}";
            Work(cd);
            if (selected_customer.Limitation() == true)
            {
                int RD = rnd.Next(1, 30);
                Treaty t = new Treaty(selected_administrator, selected_customer, selected_car, selected_RentalPoint, RD);
                selected_car.Сharacteristics();
                cd = $"{selected_administrator.FullName} будет обслуживать клиента {selected_customer.FullName}";
                Work(cd);
                t.CompleteRentalProcess();
                selected_RentalPoint = RP[rnd.Next(RP.Count)];
                cd = $"{selected_customer.FullName} возвращает автомобиль в прокат на {selected_RentalPoint.Address}";
                Work(cd);
            }
            else { cd = "Вы не можете взять машину в прокат, так как ваш водительский опыт меньше одного года"; Work(cd); }

        }
    }
}

    
