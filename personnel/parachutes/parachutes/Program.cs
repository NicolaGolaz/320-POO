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

            List<Para> parachuteInTheAir = new List<Para>();

            Plane plane = new Plane();


            Console.CursorVisible = false;

            ConsoleKeyInfo  keyPressed;




            for (int i = 0; i < 8; i++)
            {
                plane.board( new Para("bob " + i.ToString()));
            }


            while (true)
            {

                if (Console.KeyAvailable) // L'utilisateur a pressé une touche
                {
                    keyPressed = Console.ReadKey(false);
                    switch (keyPressed.Key)
                    {
                        case ConsoleKey.Escape:
                            Environment.Exit(0);
                            break;
                        case ConsoleKey.Spacebar:
                            Para jumper = plane.dropParachutist();
                            parachuteInTheAir.Add(jumper);
                            break;
                        default:
                            break;
                    }
                }

                plane.update();
                foreach (Para para in parachuteInTheAir)
                {
                    para.update();
                }


                plane.draw();
                foreach (Para para in parachuteInTheAir)
                {
                    para.draw();
                }

                Thread.Sleep(100);
                Console.Clear();

            }


           

        }
    }
}
