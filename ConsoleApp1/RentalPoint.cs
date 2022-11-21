using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    [Serializable]
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
        public void SelectedCar(Car[] array)
        {
            
            for (int i=0;i<C.Count;i++)
            {

                if (C[i].Availability == true) array[i] = C[i]; 



                }

        }
       
    }
}
