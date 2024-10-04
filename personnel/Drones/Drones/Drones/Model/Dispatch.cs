using Drones.Helpers;
using Drones.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones.Model
{
    public class Dispatch : IDispatchable
    {
        private int x = 80;
        private int y = 80;
        private int disPositionX = 600;
        private int disPositionY = 300;


        private SolidBrush dispatchBrush = new SolidBrush(Color.Blue);

        public List<Box> Boxes { get; set; }

        public Dispatch()
        {
            Boxes = new List<Box>();
        }

        public void Render(BufferedGraphics drawingSpace)
        {
            drawingSpace.Graphics.FillRectangle(dispatchBrush, new Rectangle(disPositionX - 4, disPositionY - 2, x, y));
        }

        public void Ajouter(Box box)
        {
          Boxes.Add(box);
        }

        public void Retirer(Box box)
        {
           Boxes.Remove(box);
        }
    }
}
