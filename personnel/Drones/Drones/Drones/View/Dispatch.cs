using Drones.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones.View
{
    internal class Dispatch
    {
        private int x = 80;
        private int y = 80;
        private int disPositionX = 600;
        private int disPositionY = 300;


        private Pen dispatchBrush = new Pen(new SolidBrush(Color.Blue), 3);
        public void Render(BufferedGraphics drawingSpace)
        {
            drawingSpace.Graphics.DrawRectangle(dispatchBrush, new Rectangle(disPositionX - 4, disPositionY - 2, x, y));
        }
    }
}
