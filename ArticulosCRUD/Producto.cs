namespace ArticulosCRUD
{

    internal class Producto
    {
        public string Nombre { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set;  }
        public int Id { get; set;  }

        public Producto(int id, string nombre, int cantidad, decimal precio)
        {
            Id = id;
            Nombre = nombre;
            Cantidad = cantidad;
            Precio = precio;
        }

    }
    
}