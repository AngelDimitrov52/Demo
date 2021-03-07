﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PersonInfo
{
    public class Citizen : IPerson, IIdentifiable , IBirthable
    {
        public Citizen(string name, int age, string id , string birtthDate)
        {
            Name = name;
            Age = age;
            Id = id;
            Birthdate = birtthDate;
        }
        public string Name { get; private set; }
        public int Age { get; private set; }
        public string Id { get; private set; }
        public string Birthdate { get; private set ; }

        public int Food { get; private set; }

        public void BuyFood()
        {
            Food += 10;
        }
    }
}
