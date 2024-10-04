using Drones.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones.View
{
    public class Box
    {
        private int boxId;
        private int kilos;
        private Color color;
        public int BoxId { get => boxId; set => boxId = value; }
        public int Kilos { get => kilos; set => kilos = value; }

        public Box(int boxId, int kilos)
        {
            BoxId = boxId;
            Kilos = kilos;
        }

    }
}
