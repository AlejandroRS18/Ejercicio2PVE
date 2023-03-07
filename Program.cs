namespace Ejercicio2PVE;
class Program
{
    static void Main(string[] args)
    {
        Concesionaria concesionaria = new Concesionaria(3);
        Automovil auto1 = new Automovil { ID = 1, Marca = "Toyota", Km = 1500, Precio = 450000 };
        Automovil auto2 = new Automovil { ID = 2, Marca = "RAM", Km = 20000, Precio = 10500 };
        Automovil auto3 = new Automovil { ID = 3, Marca = "Chevrolet", Km = 75000, Precio = 50000 };
        concesionaria.AgregarAuto(auto1);
        concesionaria.AgregarAuto(auto2);
        concesionaria.AgregarAuto(auto3);
        concesionaria.MostrarAutos();


    }
}
