﻿using System;

namespace IEnumerableIEnumerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Fruit[] fruits = {new Fruit("Яблоко", 15), new Fruit("Груша", 5), 
                new Fruit("Ананас", 16), new Fruit("Апельсин", 2)};

            Basket basket = new Basket(fruits);
            foreach (var item in basket)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            var enumerator = basket.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
        }
    }
}
