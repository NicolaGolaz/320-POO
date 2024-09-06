using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classPlane
{
    internal class Plane
    {
        // Attributs

        private int x = 0;
        private int y = 0;

        public string[] view =
        {
            @" _                         ",
            @"| \                        ",
            @"|  \       ______          ",
            @"--- \_____/  |_|_\____  |  ",
            @"  \_______ --------- __>-} ",
            @"        \_____|_____/   |  "
        };


        // Constructeur

        // Méthodes 

        public void draw()
        {
            
            foreach (string line in view)
            {
            

                Console.SetCursorPosition(x, Console.CursorTop);
                Console.WriteLine(line);
            }

        }

        public void update()
        {
            x++;
           
        }


    }
}
