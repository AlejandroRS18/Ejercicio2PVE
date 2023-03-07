namespace Ejercicio2PVE;
class Concesionaria
    {
        private List<Vehiculo> vehiculos;

        public Concesionaria()
        {
            vehiculos = new List<Vehiculo>();
        }

        public void AgregarVehiculo(Vehiculo vehiculo)
        {
            vehiculos.Add(vehiculo);
        }

        public void VenderVehiculo(Vehiculo vehiculo)
        {
            vehiculos.Remove(vehiculo);
        }

        public void MostrarVehiculos()
        {
            Console.WriteLine("Vehículos disponibles:");
            foreach (Vehiculo vehiculo in vehiculos)
            {
                Console.WriteLine(vehiculo.ToString());
            }
            Console.WriteLine("");
        }
    }