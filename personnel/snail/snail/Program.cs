﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using ExerciceSnail;
namespace snail
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Snail> snails = new List<Snail>();

            Snail toto = new Snail();
            Snail titi = new Snail();

            snails.Add(toto);
            snails.Add(titi);

            int intVie = 50;
            const int intMaxPv = 50;
            string strSnail = "_@_ö";

            for (int i = 0; i < toto.plife; i++)
            {


                Thread.Sleep(50);
                Console.Clear();
                Console.CursorVisible = false;
                Console.SetCursorPosition(i, 5);
                Console.WriteLine(toto.alive);

               


                intVie = intVie - 1;

            }
            Console.Clear();
            Console.SetCursorPosition(intMaxPv, 5);
            
            Console.WriteLine(toto.dead);
            Console.ReadLine();
        }
    }
}
