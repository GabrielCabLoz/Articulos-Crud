namespace Examen1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string titulo = "Blue Casino - Juego de Ruleta";

            

            string[] opciones =
            [
                "Jugar Ruleta",
                "Ver Historial",
                "Ver Dinero",
                "Retirarse"
            ];

            Menu menu = new Menu(titulo, opciones);
            menu.MostrarMenu();
        }
    }
}