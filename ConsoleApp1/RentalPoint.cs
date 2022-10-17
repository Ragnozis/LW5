using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class RentalPoint
    {
        private string? address;
        public string? Address { get { return address; } set { address = value; } } // доделать конструкторы для создания коллекций автомобилей и администраторов
        private List<Car> c;
        public List<Car> C { get { return c; } set { c = value; } }
         public RentalPoint(string address)
          {
              this.Address = address;
              C = new List<Car>();


          }
                   // также доделать методы для добавления машин и администраторов в нужные коллекции ( по одному)
          public void AddCar(Car item)
          {
              C.Add(item);
          }
          public void AddAdministrator(Administrator a1, Administrator a2)
          {
              List<Administrator> a = new List<Administrator>();
              a.Add(a1);
              a.Add(a2);

          }
        
        
    }
}
