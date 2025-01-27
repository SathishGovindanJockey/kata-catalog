﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 500; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    string num = i.ToString();

                    if (num.Contains("3") && num.Contains("5"))
                    {
                        Console.WriteLine("FizzBuzz");
                    }
                    else if (num.Contains("3"))
                    {
                        Console.WriteLine("Fizz");
                    }
                    else if (num.Contains("5"))
                    {
                        Console.WriteLine("Buzz");
                    }
                    else
                    {
                        Console.WriteLine(num);
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
