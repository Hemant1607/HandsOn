﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializationQ2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.CreatePerson();
            p.ToString();
            //Console.WriteLine(s);

            Console.Read();
        }
    }
}
