using Drones.View;

namespace Drones
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            // Création de la flotte de drones
            List<Drone> fleet = new List<Drone>();
            for (int i = 0; i < 5; i++)
            {
                Drone drone = new Drone(Helper.PositionX(), Helper.PositionY());

                drone.Name = "Joe";
                fleet.Add(drone);
            }

            Drone drone1 = new Drone(Helper.PositionX(), Helper.PositionY());

            drone1.Name = "Jack";
            drone1.Charge = 10000;
            fleet.Add(drone1);


            List<Building> buildings = new List<Building>();

            for (int i = 0; i < Building.NbrBuild; i++)
            {
                Factory factory = new Factory();
                buildings.Add(factory);

                Store store = new Store();
                buildings.Add(store);
            }

            try
            {


                // Démarrage
                Application.Run(new AirSpace(fleet, buildings));
            }
            catch (Exception e)
            {
                throw new Exception($"Une erreur est survenue !{e.Message}");
            }
        }
    }
}