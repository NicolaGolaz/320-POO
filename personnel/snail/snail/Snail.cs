using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceSnail
{
    internal class Snail
    {
        // Attributs

        public int plife = 50;           // point de vie
        public int x = 0;                // position
        public int y;
        public string alive = "_@_ö";    // escargot vivant
        public string dead = "____";     // escargot mort

        // Constructeur

        public Snail(int y)
        {
            this.y = y;
        }

        public Snail()
        {
            y = 12;
        }

        // Méthodes

        public void Move()
        {
            x++;
            plife--; // un déplacement coute un point de vie 
        }
    }
}
