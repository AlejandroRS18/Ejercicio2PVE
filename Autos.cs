namespace Ejercicio2PVE;
    class Auto
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Anho { get; set; }
        public double Precio { get; set; }

        public Vehiculo(string marca, string modelo, int anho, double precio)
        {
            Marca = marca;
            Modelo = modelo;
            Anho = anho;
            Precio = precio;
        }

        public override string ToString()
        {
            return $"Marca: {Marca} - Modelo: {Modelo} - Año: {Anho} - Precio: {Precio}";
        }
    }
    
