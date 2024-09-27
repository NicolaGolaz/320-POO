

using System.Security.Policy;

namespace Drones
{
    // Cette partie de la classe Drone définit ce qu'est un drone par un modèle numérique
    public partial class Drone : IExpellable
    {
        Random alea = new Random();

        private int charge = Config.charge;                     // La charge actuelle de la batterie
        private string name;                           // Un nom
        private int x ;                                // Position en X depuis la gauche de l'espace aérien
        private int y;                                 // Position en Y depuis le haut de l'espace aérien
        private Rectangle _droneRectangle;
        EvacuationState state = EvacuationState.Free;
        private Rectangle noflyzone;

        public int Charge { get => charge; set => charge = value; }
        public string Name { get => name; set => name = value; }
        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }

        public bool Evacuate(Rectangle zone)
        {
            noflyzone = zone;
            
            return !_droneRectangle.IntersectsWith(zone);
        }

        public void FreeFlight()
        {
            this.state = EvacuationState.Free;
            noflyzone = Rectangle.Empty;
        }

        public EvacuationState GetEvacuationState()
        {
            return this.state;
        }

        public Drone(int x, int y)
        {
            this.x = x;
            this.y = y;
            _droneRectangle = new Rectangle(x, y, Helper.DroneSize, Helper.DroneSize);
        }


        // Cette méthode calcule le nouvel état dans lequel le drone se trouve après
        // que 'interval' millisecondes se sont écoulées
        public void Update(int interval)
        {
            x += 2;                                    // Il s'est déplacé de 2 pixels vers la droite
            y += alea.Next(-2, 3);                     // Il s'est déplacé d'une valeur aléatoire vers le haut ou le bas
            charge--;                                  // Il a dépensé de l'énergie
        }

    }
}
