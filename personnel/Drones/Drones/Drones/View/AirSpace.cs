using Drones.Model;
using Drones.View;

namespace Drones
{
    // La classe AirSpace représente le territoire au dessus duquel les drones peuvent voler
    // Il s'agit d'un formulaire (une fenêtre) qui montre une vue 2D depuis en dessus
    // Il n'y a donc pas de notion d'altitude qui intervient

    public partial class AirSpace : Form
    {




        // La flotte est l'ensemble des drones qui évoluent dans notre espace aérien
        private List<Drone> fleet;
        private List<Building> buildings;
        private Dispatch dispatch = new Dispatch();

        BufferedGraphicsContext currentContext;
        BufferedGraphics airspace;

        // Initialisation de l'espace aérien avec un certain nombre de drones
        public AirSpace(List<Drone> fleet, List<Building> buildings)
        {

            if (fleet.Count > 10)
            {
                throw new ArgumentException("La flotte est plus grande que 10 !");
            }

            InitializeComponent();
            // Gets a reference to the current BufferedGraphicsContext
            currentContext = BufferedGraphicsManager.Current;
            // Creates a BufferedGraphics instance associated with this form, and with
            // dimensions the same size as the drawing surface of the form.
            airspace = currentContext.Allocate(this.CreateGraphics(), this.DisplayRectangle);
            this.fleet = fleet;
            this.buildings = buildings;


        }

        // Affichage de la situation actuelle
        private void Render()
        {
            airspace.Graphics.Clear(Color.AliceBlue);

            // draw drones
            foreach (Drone drone in fleet)
            {
                drone.Render(airspace);
            }

            dispatch.Render(airspace);

            // draw buidings
            foreach (Building building in buildings)
            {
                if (building.GetType() == typeof(Factory))
                {
                    Factory factory = (Factory)building;
                    factory.Render(airspace);
                }
                else if (building.GetType() == typeof(Store))
                {
                    Store store = (Store)building;
                    store.Render(airspace);
                }

            }

            airspace.Render();
        }

        // Calcul du nouvel état après que 'interval' millisecondes se sont écoulées
        private void Update(int interval)
        {
            foreach (Drone drone in fleet)
            {
                drone.Update(interval);
            }
            foreach (Building building in buildings)
            {
                if(building is Factory factory)
                    factory.Update(interval, dispatch);
            }
        }

        // Méthode appelée à chaque frame
        private void NewFrame(object sender, EventArgs e)
        {
            this.Update(ticker.Interval);
            this.Render();
        }
    }
}