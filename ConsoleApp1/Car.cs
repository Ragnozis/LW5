using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;

namespace ConsoleApp1
{ 
    internal class Car 
    {
        private  string? brand;
        public  string? Brand { get { return brand; } set { brand = value; } }
        private string? model;
        public string? Model { get { return model; } set { model = value; } }
        private string? number;
        public string? Number { get { return number; } set { number = value; } }
        private ushort power;
        public ushort Power { get { return power; } set { power = value; } }
        private ushort maxSpeed;
        public ushort MaxSpeed { get { return maxSpeed; } set { maxSpeed = value; } }
        private ushort engineCapacity;
        public ushort EngineCapacity { get { return engineCapacity; } set { engineCapacity = value; } }
        private double consumption;
        public double Consumption { get { return consumption; } set { consumption = value; } }
        private ushort tankVolume;
        public ushort TankVolume { get { return tankVolume; } set { tankVolume = value; } }
        private bool availability;
        public bool Availability { get { return availability; } set { availability = value; } }
        private int price;
        public int Price { get { return price; } set { price = value; } }

        public Car(string? brand, string? model, string? number, ushort power, ushort maxspeed, ushort engineCapacity, double consumption, ushort tankVolume, bool availability, int price)
        {
            this.Brand = brand;
            this.Model = model;
            this.Number = number;
            this.Power = power;
            this.MaxSpeed = maxSpeed;
            this.EngineCapacity = engineCapacity;
            this.Consumption = consumption;
            this.TankVolume = tankVolume;
            this.Availability = availability;
            this.Price = price;
        }
        
        public string Сharacteristics()
        {
            Console.WriteLine("Характеристики автомобиля: ");
            Console.WriteLine($"Марка автомобиля: {brand}");
            Console.WriteLine($"Модель автомобиля: {model}");
            Console.WriteLine($"Номер автомобиля: {number}");
            Console.WriteLine($"Мощность двигателя автомобиля: {power}");
            Console.WriteLine($"Максимальная скорость автомобиля: {maxSpeed}");
            Console.WriteLine($"Объем двигателя автомобиля: {engineCapacity}");
            Console.WriteLine($"Расход топлива автомобиля: {consumption}");
            Console.WriteLine($"Объем бака автомобиля: {tankVolume}");
            if (availability == true) Console.WriteLine($"Доступность автомобиля: свободен ");
            else Console.WriteLine($"Доступность автомобиля: занят ");
            Console.WriteLine($"Цена за сутки проката автомобиля: {price}");
            return "";
        }

    }
}
