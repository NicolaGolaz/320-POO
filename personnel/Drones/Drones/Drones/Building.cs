using Drones.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Drones
{
    public class Building
    {
        private Random random = new Random();

        public int x = Helper.PositionX();
        public int y = Helper.PositionY();
        public int largeur = 30;
        public int longueur = 30;
        public static Color color = Color.Red;
        public const int NbrBuild = 4;



        public Pen buildingBrush = new Pen(new SolidBrush(color), 3);

        public void Render(BufferedGraphics drawingSpace)
        {


            drawingSpace.Graphics.DrawRectangle(buildingBrush, new Rectangle(x, y, longueur, longueur));

        }

    }
}
