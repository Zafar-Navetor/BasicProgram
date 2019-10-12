using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataType
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 5;

            int sum = a + b;
            int Mul = a * b;
            int sub = a - b;

            Console.WriteLine($"sum = {sum} Mul = {Mul} sub = {sub}");
            Console.ReadLine();

            String FirstName = "Zafar";
            String LastName = "Ahmad";
            String FullName = FirstName + " " + LastName;

            Console.WriteLine("My Name is:" + FullName);
            Console.ReadLine();
        }
    }
}
