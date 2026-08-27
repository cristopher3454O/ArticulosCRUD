namespace ArticulosCRUD
{

    internal class Menu
    {
        public Menu()
        {
            
        }
        public void MostrarMenu()
        {
            bool continuar = true;
            while (continuar)
            {
                Console.Clear();
                Console.WriteLine("Gestor de articulos");
                Console.WriteLine("===================");
                Console.WriteLine("1. Agregar");
                Console.WriteLine("2. Listar");
                Console.WriteLine("3. Buscar");
                Console.WriteLine("4. Modificar");
                Console.WriteLine("5. Eliminar");
                Console.WriteLine("0. Salir");
                string opcion = Console.ReadLine() ?? "";
                switch (opcion)
                {
                    case "0": continuar = false; break;
                    default :
                        Console.WriteLine("Opcion invalida");
                        Console.ReadLine();
                        break; 
                } 
            }
            
        }

        public void MostrarAgregar()
        {
            Console.Clear();
            Console.WriteLine("Opción Agregar Seleccionada");
            Console.ReadLine();
        }
    }
}