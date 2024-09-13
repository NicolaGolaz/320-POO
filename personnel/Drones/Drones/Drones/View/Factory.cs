using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones.View
{
    public class Factory : Building
    {
        private int PowerConsuption;
        public static new Color color = Color.Red;

        public Pen factoryBrush = new Pen(new SolidBrush(color), 3);

        public new void Render(BufferedGraphics drawingSpace)  
        {


            drawingSpace.Graphics.DrawRectangle(factoryBrush, new Rectangle(x, y, longueur, longueur));

        }
    }
}
