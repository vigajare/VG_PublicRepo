﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberSecurity_Demo
{
    class Program
    {
      
        class Abc
        {
            public string Addlicense(string licenseName, string licenseKey)
            {
                string license = licenseName + licenseKey;
                return license;
            }
        }
        public class Class1
        {
            public decimal Calculate(decimal amount, int type, int years)
            {
                decimal result = 0;
                decimal disc = (years > 5) ? (decimal)5 / 100 : (decimal)years / 100;
                if (type == 1)
                {
                    result = amount;
                }
                else if (type == 2)
                {
                    result = (amount - (0.1m * amount)) - disc * (amount - (0.1m * amount));
                }
                else if (type == 3)
                {
                    result = (0.7m * amount) - disc * (0.7m * amount);
                }
                else if (type == 4)
                {
                    result = (amount - (0.5m * amount)) - disc * (amount - (0.5m * amount));
                }
                return result;
            }
        }

        static void Main(string[] args)
        {
            Abc objabc = new Abc();
            Class1 obj = new Class1();
            var var1 = 1;
            int a = 10, b = 0;
            var c = a / b; //DivideByZeroException 
            decimal result = obj.Calculate(5000, 2, 5);
            Console.WriteLine("Result = " + result);
            Console.ReadLine();
            //Console.Write("Enter input path/filename: ");
            //string inputFile = Console.ReadLine();
            //inputFile = inputFile.Length > 0 ? inputFile : "C:\\Temp\\Test.xlsx";
            //if (File.Exists(inputFile))
            //{
            //    string outputFile = "C:\\Temp\\Test.xlsx";
            //}
            var licenseName = "4434;700-terumobct.com";
            var licenseKey = "b72120c7-059c-27a4-ef1d-0589d74128d2";
            objabc.Addlicense(licenseName, licenseKey);



        }
    }
}
