using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
namespace snail
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int intVie = 50;
            const int intMaxPv = 50;
            string strSnail = "_@_ö";

            for (int i = 0; i < intMaxPv; i++)
            {


                Thread.Sleep(50);
                Console.Clear();
                Console.CursorVisible = false;
                Console.SetCursorPosition(i, 5);
                Console.WriteLine(strSnail);

                intVie = intVie - 1;

            }
            Console.Clear();
            Console.SetCursorPosition(intMaxPv, 5);
            strSnail = "____";
            Console.WriteLine(strSnail);
            Console.ReadLine();
        }
    }
}
