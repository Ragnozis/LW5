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
        private List<Administrator>? a;
        public List<Administrator>? A { get { return a; } set { a = value; } }
        public RentalPoint(string address, List<Car> C, List<Administrator> A)
          {
              this.Address = address;
              this.C = C;
              this.A = A;
          }
        public void AddCar(Car item)
         {
            C.Add(item);
         }
        public void AddAdministrator(Administrator item)
        {
            A.Add(item);
        }
        public List<Car> SelectCar()
        {
            List<Car> array = new List<Car>();
            foreach (Car ca in C)
            {

                if (ca.Availability == true) array.Add(ca); 



                }
            return array;   

        }
       
    }
}
