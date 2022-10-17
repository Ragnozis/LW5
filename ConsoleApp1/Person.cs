﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Person  // сделать класс абстрактным и удалить конструктор
    {
        private string? fullName;
        public string? FullName { get { return fullName; } set { fullName = value; } }
        private string? gender;
        public string? Gender { get { return gender; } set { gender = value; } }
        private ushort age;
        public ushort Age { get { return age; } set { age = value; } }
        public Person(string? fullName, string? gender, ushort age) 
        {
            this.FullName = fullName;
            this.Gender = gender;
            this.Age = age;
        }
    }
}
