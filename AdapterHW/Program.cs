using System;
using System.Collections.Generic;
using System.Linq;

namespace MyApp // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IDollarPay payDollarToEuro = new AdapterPay();
            int x = new Random().Next(1000);
            Pay(payDollarToEuro, x);
        }

        static void Pay(IDollarPay payDollarToEuro, double x)
        {
            Console.WriteLine(payDollarToEuro.Pay(x));
        }
    }
}