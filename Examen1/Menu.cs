namespace Examen1
{
    internal class Menu
   
    {
       
       
            private readonly string Titulo;
            private readonly string[] Opciones;

            public Juego Juego { get; set; }

            public Menu(string titulo, string[] opciones)
            {
                Titulo = titulo;
                Opciones = opciones;
                Juego = new Juego();
            }

            public void MostrarMenu()
            {
                bool continuar = true;

                while (continuar)
                {
                    Console.Clear();
                    Console.WriteLine("   ");
                    Console.WriteLine("Bienvenidos al Blue Casino");
                    Console.WriteLine("Esperamos que su estancia sea azulástica");
                    Console.WriteLine("Recuerda que debes apostar responsablemente");
                    Console.WriteLine("   ");

                    Console.WriteLine(Titulo);
                    Console.WriteLine(new string('=', Titulo.Length));

                    for (int i = 0; i < Opciones.Length; i++)
                    {
                        Console.WriteLine($"{i + 1}. {Opciones[i]}");
                    }

                    string opcion = Console.ReadLine() ?? "";

                    switch (opcion)
                    {
                        case "0":
                            continuar = false;
                            break;

                        case "1":
                            jugar();
                            break;

                        case "2":
                            verHistorial();
                            break;

                        case "3":
                            verDinero();
                            break;

                        case "4":
                            retirarse();
                            continuar = false;
                            break;

                        default:
                            Console.WriteLine("Opción inválida");
                            Console.ReadLine();
                            break;
                    }
                }
            }

            private void jugar()
            {
                Juego.Jugar();
            }

            private void verHistorial()
            {
                Juego.VerHistorial();
            }

            private void verDinero()
            {
                Juego.VerDinero();
            }

            private void retirarse()
            {
                Juego.Retirarse();
            }
        }
}
