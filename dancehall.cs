using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double hallLenght = double.Parse(Console.ReadLine());
            double hallWidth = double.Parse(Console.ReadLine());
            double wardrobeSide = double.Parse(Console.ReadLine());

            double hallarea = (hallLenght * 100) * (hallWidth * 100);
            double wardrobearea = wardrobeSide * 100 * wardrobeSide * 100;
            double bench = hallarea / 10;
            double free = hallarea - wardrobearea - bench;
            double dancers = free / (40 + 7000);

            Console.WriteLine(Math.Floor(dancers));

        }
    }
}
