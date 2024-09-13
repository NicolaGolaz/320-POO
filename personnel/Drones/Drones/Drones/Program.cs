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
            List<Drone> fleet= new List<Drone>();
            Drone drone = new Drone();
            drone.X = Helper.PositionX();
            drone.Y = Helper.PositionY();
            drone.Name = "Joe";
            fleet.Add(drone);

            List<Building> buildings = new List<Building>();
            
            for (int i = 0; i < Building.NbrBuild; i++)
            {
                Building building = new Building();
                buildings.Add(building);
            }

            // Démarrage
            Application.Run(new AirSpace(fleet, buildings));
        }
    }
}