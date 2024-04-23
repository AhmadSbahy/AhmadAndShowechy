using AhmadAndShowechy.PlusAndMinus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AhmadAndShowechy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IPlusAndMinus plusAndMinus = new PlusAndMinus.PlusAndMinus();

            Console.WriteLine("Enter your Target");
            string target = Console.ReadLine();
            Console.WriteLine("Enter Number 1");
            float number1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Number 2");
            float number2 = float.Parse(Console.ReadLine());
        }
    }
}
