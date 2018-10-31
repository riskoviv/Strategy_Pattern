﻿using Strategy_Pattern.Ducks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            List<DuckBase> ducks = new List<DuckBase>
            {
                new ExoticDuck(),
                new SimpleDuck(),
                new WoodenDuck(),
                new RubberDuck()
            };

            foreach (var duck in ducks)
            {
                duck.Display();
                duck.Swim();
                duck.Quack();
                duck.Fly();

                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
