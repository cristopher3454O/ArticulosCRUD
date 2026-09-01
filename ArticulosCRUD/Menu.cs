namespace ArticulosCRUD
{

    internal class Menu
    {
        private readonly string Titulo;
        private readonly string[] Opciones;
        private List<Producto> ListaProductos;
        public Menu(string titulo, string[] opciones)
        {
            Titulo = titulo;
            Opciones = opciones;
            ListaProductos = new List<Producto>();
        }
        public void MostrarMenu()
        {
            bool continuar = true;
            while (continuar)
            {
                Console.Clear();
                Console.WriteLine(Titulo);
                Console.WriteLine(new string ('=', Titulo.Length));

                for (int i = 0; i < Opciones.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {Opciones[i]}");
                    
                }
                Console.WriteLine("0. Salir"); 

                
                /*Console.WriteLine("Gestor de articulos");
                Console.WriteLine("===================");
                Console.WriteLine("1. Agregar");
                Console.WriteLine("2. Listar");
                Console.WriteLine("3. Buscar");
                Console.WriteLine("4. Modificar");
                Console.WriteLine("5. Eliminar");
                Console.WriteLine("0. Salir"); */
                string opcion = Console.ReadLine() ?? "";
                switch (opcion)
                {
                    case "0": continuar = false; break;
                    case "1": MostrarAgregar(); break;
                    case "2": MostrarListar(); break;
                    case "3": MostrarBuscar(); break;
                    case "4": MostrarModificar(); break;
                    case "5": MostrarEliminar(); break;
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
        public void MostrarListar()
        {
            Console.Clear();
            Console.WriteLine("Opción Listar Seleccionada");
            Console.ReadLine();
        }
        public void MostrarBuscar()
        {
            Console.Clear();
            Console.WriteLine("Opción Buscar Seleccionada");
            Console.ReadLine();
        }
        public void MostrarModificar()
        {
            Console.Clear();
            Console.WriteLine("Opción Modifcar Seleccionada");
            Console.ReadLine();
        }
        public void MostrarEliminar()
        {
            Console.Clear();
            Console.WriteLine("Opción Eliminar Seleccionada");
            Console.ReadLine();
        }
    }
}