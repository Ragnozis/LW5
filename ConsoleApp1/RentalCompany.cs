using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class RentalCompany //:  ISerializable // реализовать интерфейс ISerializable + 
    {
        public delegate void d1(string c);
        private static void Message(string c)
        {
            Console.WriteLine(c);
        }
        

        static void Main(string[] args)
        {
            Random rnd;
            int value;
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
            List<RentalPoint> RP = new List<RentalPoint>() { r1,r2,r3,r4};
            List<Customer> customers = new List<Customer>() { ct1, ct2, ct3, ct4 };

            // Treaty t = new Treaty();
            // Customer ct = new Customer("", "", 0, "", 0, 0, 0);
            //RentalPoint r = new RentalPoint("", new List<Car>(), new List<Administrator>());
            //Administrator a = new Administrator("", "", 0);
            //Car c = new Car("", "", "", 0, 0, 0, 0, 0, true, 0);

            rnd = new Random();

            var selected_customer =customers[rnd.Next(customers.Count)];
            rnd = new Random();
            var selected_RentalPoint = RP[rnd.Next(RP.Count)];
            rnd = new Random();
            var selected_car = r1.C[rnd.Next(r1.C.Count)];
            //   Console.WriteLine($"{ct.FullName} направляется в прокат на {r.Address}");
            string cd = $"{selected_customer.FullName} направляется в прокат на {selected_RentalPoint.Address}";
            d1 Work = new(Message);
            Work(cd);
            rnd = new Random();
          value = rnd.Next(1, 2);
        /*  if (value1 == 1 && value == 1) a = a1;
          if (value1 == 1 && value == 2) a = a2;
          if (value1 == 2 && value == 1) a = a3;
          if (value1 == 2 && value == 2) a = a4;
          if (value1 == 3 && value == 1) a = a5;
          if (value1 == 3 && value == 2) a = a6;
          if (value1 == 4 && value == 1) a = a7;
          if (value1 == 4 && value == 2) a = a8;
          rnd = new Random();
          value = rnd.Next(1, 4);
          if (value1 == 1 && value == 1) c = c1;
          if (value1 == 1 && value == 2) c = c2;
          if (value1 == 1 && value == 3) c = c3;
          if (value1 == 1 && value == 4) c = c4;
          if (value1 == 2 && value == 1) c = c4;
          if (value1 == 2 && value == 2) c = c7;
          if (value1 == 2 && value == 3) c = c2;
          if (value1 == 2 && value == 4) c = c5;
          if (value1 == 3 && value == 1) c = c6;
          if (value1 == 3 && value == 2) c = c2;
          if (value1 == 3 && value == 3) c = c8;
          if (value1 == 3 && value == 4) c = c4;
          if (value1 == 4 && value == 1) c = c4;
          if (value1 == 4 && value == 2) c = c7;
          if (value1 == 4 && value == 3) c = c8;
          if (value1 == 4 && value == 4) c = c1;
     //     Console.WriteLine($"{ct.FullName} планирует взять в прокат автомобиль {c.Brand} {c.Model} ");
          c.Сharacteristics();
          if (c.Availability == false) Console.WriteLine("Данная машина в данный момент недоступна");
          if (c.Availability == true)
          {
              if (t.Check(ct) == true)
              {
                  t.Create(ct, r, a, c);
                  rnd = new Random();
                  value = rnd.Next(1, 4);
                  if (value == 1) r = r4;
                  if (value == 2) r = r3;
                  if (value == 3) r = r2;
                  if (value == 4) r = r1;
                  Console.WriteLine($"{ct.FullName} возвращает автомобиль в прокат на {r.Address}");
                  t.Return(ct, c, a);
              }
              else Console.WriteLine("Вы не можете взять машину в прокат, так как ваш водительский опыт меньше одного года");
          }
          */

        }
    }
}

