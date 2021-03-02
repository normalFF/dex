using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;

namespace topic_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 100000;
            int[] arr = new int[n];
            long ellapledTicks;     // ellapledTicks где-то используется?
            int x = 123;
            double sum = 0;
            object[] o = new object[n];


            Stopwatch stopwatch = new Stopwatch();
            Console.WriteLine("Измерение времени выполнения при помощи класса Stopwatch");
            Console.WriteLine("****измеряем скорость boxing****") ;
            stopwatch.Start();
            for (int i = 0; i < n; i++)
            {              
                o[i] = i;
            }
            stopwatch.Stop();
            Console.WriteLine("Средняя скорость операции =" + Convert.ToDouble(stopwatch.ElapsedTicks)/n);
            stopwatch.Reset();
           
            Console.WriteLine("****измеряем скорость unboxing****");
            stopwatch.Start();
            for (int i = 0; i < n; i++)
            {
                x = (int)o[i];
            }
            stopwatch.Stop();
            Console.WriteLine("Средняя скорость операции =" + Convert.ToDouble(stopwatch.ElapsedTicks) / n);
            stopwatch.Reset();

            Console.WriteLine("****измеряем скорость присваивания****");
            stopwatch.Start();
            for (int i = 0; i < n; i++)
            {
                x = 1;
            }
            stopwatch.Stop();
            Console.WriteLine("Средняя скорость операции =" + Convert.ToDouble(stopwatch.ElapsedTicks) / n);
            stopwatch.Reset();
        }
    }
}
