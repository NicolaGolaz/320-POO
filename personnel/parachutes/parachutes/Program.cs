using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using classPlane;
using classConfig;
using System.Data;
using System.Threading;
using System.Runtime.CompilerServices;
using parachutes;

namespace parachutes
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Plane plane = new Plane();


            Console.CursorVisible = false;

            while (true)
            {
               
                plane.update();
                plane.draw();
           

                Thread.Sleep(100);
                Console.Clear();

            }


           

        }
    }
}
