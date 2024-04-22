using Project_CS.DITests;
using Project_CS.Factories;
using Project_CS.Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_CS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IComputerFactory CreateFactory = new ComputerFactory();
            TestClass test = new TestClass(CreateFactory);
            test.Run();
            Console.WriteLine();


            Console.WriteLine("-------------------SecondTest--------------------");
            SecondTest secondTest = new SecondTest();
            secondTest.Run(CreateFactory);
            Console.ReadLine();
        }
    }
}
