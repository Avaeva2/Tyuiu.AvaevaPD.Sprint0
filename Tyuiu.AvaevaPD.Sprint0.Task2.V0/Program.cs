﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.AvaevaPD.Sprint0.Task2.V0.Lib;

namespace Tyuiu.AvaevaPD.Sprint0.Task2.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            // Вызов класса DataService и метода GetMessage
            // из библиотеки Tyuiu.AvaevaPD.Sprint0.Task2.V0.Lib
            Console.WriteLine(DataService.GetMessage("Полина"));
            Console.ReadKey();
            Console.ReadKey();
        }
    }
}
