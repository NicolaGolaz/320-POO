using Drones.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones.Model
{
    interface IDispatchable
    {
        List<Box> boxes { get; set; }
        public void Ajouter(Box box);
        public void Retirer(Box box);

        
    }
}
