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
        public string? Address { get { return address; } set { address = value; } }
        private List<Car>? c;
        public List<Car>? C { get { return c; } set { c = value; } }
         public RentalPoint(string address, List<Car>? c)
          {
              this.Address = address;
              C = new List<Car>();


          }

          public void AddCar(List<Car> c)
          {
              c.Add();
              c.Add(c2);
              c.Add(c3);
              c.Add(c4);
          }
          public void AddAdministrator(Administrator a1, Administrator a2)
          {
              List<Administrator> a = new List<Administrator>();
              a.Add(a1);
              a.Add(a2);

          }
        
    }
}
