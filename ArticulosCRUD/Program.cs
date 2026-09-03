namespace ArticulosCRUD
{
    class Program
    {
        static void Main(string[] args)
        {
            string titulo = "Gestor de Articulos";
            string[] opciones = ["Agregar", "Listar", "Buscar Por ID","Buscar por Nombre", "Modificar", "Eliminar"];
            Menu menu = new Menu(titulo, opciones);
            menu.MostrarMenu();
        }
    }
}