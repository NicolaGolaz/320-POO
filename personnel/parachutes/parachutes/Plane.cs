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

        private string[] view =
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

        public void Move()
        {
            x++;
        }

    }
}
