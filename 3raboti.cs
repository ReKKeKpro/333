﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double first, second, third;
            Console.WriteLine("Первое число");
            first = double.Parse(Console.ReadLine());
            Console.WriteLine("Второе число");
            second = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите 3 число");
            third = double.Parse(Console.ReadLine());
            double sum = first + second + third;
            double mult = first * second * third;
            Console.WriteLine("Сумма 3 чисел: " + sum);
            Console.WriteLine("Произведение 3 чисел: " + mult);

        }
    }
}
