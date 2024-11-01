﻿using Drones.Model;
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
        private int _powerConsuption;

        private int _id;

        private int boxTimer = 0;

        private Pen factoryBrush = new Pen(new SolidBrush(Color.Red), 3);

        int i = 0;
        public Factory(int id)
        {
            Id = id;
        }

        public int PowerConsuption { get => _powerConsuption; set => _powerConsuption = value; }
        public int Id { get => _id; set => _id = value; }



        public new void Render(BufferedGraphics drawingSpace)
        {



            base.Render(drawingSpace);
            drawingSpace.Graphics.DrawRectangle(factoryBrush, new Rectangle(x, y, longueur, longueur));
        }

        public new void Update(int interval, Dispatch dispatch)
        {
            boxTimer += interval;
            if (boxTimer >= 5000 + Helper.boxTime())
            {
                Box box = new Box(i++, Helper.boxKilos());
                Console.WriteLine("Carton produit" + box.BoxId);
                dispatch.Ajouter(box);
                boxTimer = 0;
            }

        }
    }
}
