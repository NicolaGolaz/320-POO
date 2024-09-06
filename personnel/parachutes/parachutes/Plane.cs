using classConfig;
using parachutes;
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
        private int altitude;
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

        public List<Para> parachutists;
        

        // Constructeur

        // Méthodes 

        public Plane ()
        {
            x = 0;
            altitude = Config.SCREEN_HEIGHT;
            parachutists = new List<Para> ();

        }

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

        public void board(Para para)
        {
            this.parachutists.Add(para);
        }

        internal Para dropParachutist()
        {
            Para parachutist = parachutists.First();
            parachutists.Remove(parachutist);
            parachutist.X = x;
            parachutist.Altitude = this.altitude;
            return parachutist;
        }
    }
}
