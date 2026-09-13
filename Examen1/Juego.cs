
using System;
using System.Collections.Generic;
using System.Text;



namespace Examen1
    {
        internal class Juego
        {
            public Jugador Jugador { get; set; }

            private Ruleta Ruleta;
            private List<Giro1> Historial;

            public Juego()
            {
                Jugador = new Jugador();
                Ruleta = new Ruleta();
                Historial = new List<Giro1>();
            }

            public void Jugar()
            {
                Console.Clear();

                Console.WriteLine("====== JUGAR ======");
                Console.WriteLine($"Saldo disponible: ${Jugador.Saldo}");
                Console.WriteLine();

                Console.Write("¿Cuánto deseas apostar?: ");
                string entrada = Console.ReadLine() ?? "";

                decimal apuesta;

                if (!decimal.TryParse(entrada, out apuesta))
                {
                    Console.WriteLine("La apuesta no es válida.");
                    Console.ReadLine();
                    return;
                }

                if (apuesta <= 0)
                {
                    Console.WriteLine("La apuesta debe ser mayor a 0.");
                    Console.ReadLine();
                    return;
                }

                if (apuesta % 10 != 0)
                {
                    Console.WriteLine("La apuesta debe ser múltiplo de 10.");
                    Console.ReadLine();
                    return;
                }

                if (apuesta > Jugador.Saldo)
                {
                    Console.WriteLine("No tienes suficiente saldo.");
                    Console.ReadLine();
                    return;
                }

                Console.WriteLine();
                Console.WriteLine("¿En qué deseas apostar?");
                Console.WriteLine("1. Número");
                Console.WriteLine("2. Rojo o Negro");
                Console.WriteLine("3. Par o Impar");

                string opcion = Console.ReadLine() ?? "";

                if (opcion == "1")
                {
                Console.WriteLine("Elige un número del 0 al 36:");
                Console.WriteLine();
                Console.WriteLine("Negros: 2,4,6,8,10,11,13,15,17,20,22,24,26,28,29,31,33,35");
                Console.WriteLine();
                Console.WriteLine("Rojos: 1,3,5,7,9,12,14,16,18,19,21,23,25,27,30,32,34,36");
                string entradaNumero = Console.ReadLine() ?? "";

                int numero;

                    if (!int.TryParse(entradaNumero, out numero))
                    {
                        Console.WriteLine("Número inválido.");
                        Console.ReadLine();
                        return;
                    }

                    if (numero < 0 || numero > 36)
                    {
                        Console.WriteLine("El número debe estar entre 0 y 36.");
                        Console.ReadLine();
                        return;
                    }

                    Jugador.quitarSaldo(apuesta);

                    Giro1 giro = Ruleta.girar();
                    Historial.Add(giro);

                    Console.WriteLine();
                    Console.WriteLine($"Número: {giro.numero}");
                    Console.WriteLine($"Color: {giro.color}");
                    Console.WriteLine($"Par/No Par: {giro.ParNoPar}");

                    if (numero == giro.numero)
                    {
                        Console.WriteLine("¡Ganaste!");
                        Jugador.agregarSaldo(apuesta * 10);
                    }
                    else
                    {
                        Console.WriteLine("Perdiste.");
                    }
                }

                else if (opcion == "2")
                {
                    Console.Write("Elige Rojo o Negro: ");
                    string color = Console.ReadLine() ?? "";

                    if (color.ToLower() != "rojo" &&
                        color.ToLower() != "negro")
                    {
                        Console.WriteLine("Color inválido.");
                        Console.ReadLine();
                        return;
                    }

                    Jugador.quitarSaldo(apuesta);

                    Giro1 giro = Ruleta.girar();
                    Historial.Add(giro);

                    Console.WriteLine();
                    Console.WriteLine($"Número: {giro.numero}");
                    Console.WriteLine($"Color: {giro.color}");
                    Console.WriteLine($"Par/No Par: {giro.ParNoPar}");

                    if (color.ToLower() == giro.color.ToLower())
                    {
                        Console.WriteLine("¡Ganaste!");
                        Jugador.agregarSaldo(apuesta * 5);
                    }
                    else
                    {
                        Console.WriteLine("Perdiste.");
                    }
                }

                else if (opcion == "3")
                {
                    Console.Write("Escribe Par o Impar: ");
                    string paridad = Console.ReadLine() ?? "";

                    if (paridad.ToLower() != "par" &&
                        paridad.ToLower() != "impar")
                    {
                        Console.WriteLine("Opción inválida.");
                        Console.ReadLine();
                        return;
                    }

                    Jugador.quitarSaldo(apuesta);

                    Giro1 giro = Ruleta.girar();
                    Historial.Add(giro);

                    Console.WriteLine();
                    Console.WriteLine($"Número: {giro.numero}");
                    Console.WriteLine($"Color: {giro.color}");
                    Console.WriteLine($"Par/No Par: {giro.ParNoPar}");

                    if (paridad.ToLower() == "par" && giro.ParNoPar == 2)
                    {
                        Console.WriteLine("¡Ganaste!");
                        Jugador.agregarSaldo(apuesta * 2);
                    }
                    else if (paridad.ToLower() == "impar" && giro.ParNoPar == 0)
                    {
                        Console.WriteLine("¡Ganaste!");
                        Jugador.agregarSaldo(apuesta * 2);
                    }
                    else
                    {
                        Console.WriteLine("Perdiste.");
                    }
                }

                else
                {
                    Console.WriteLine("Opción inválida.");
                    Console.ReadLine();
                    return;
                }

                Console.WriteLine();
                Console.WriteLine($"Saldo actual: ${Jugador.Saldo}");

                if (Jugador.Saldo == 0)
                {
                    Console.WriteLine("Te has quedado sin saldo.");
                    Console.WriteLine("El juego ha terminado.");
                }

                Console.ReadLine();
            }

            public void VerHistorial()
            {
                Console.Clear();

                Console.WriteLine(" HISTORIAL ");

                if (Historial.Count == 0)
                {
                    Console.WriteLine("Todavía no hay giros.");
                }
                else
                {
                    foreach (Giro1 giro in Historial)
                    {
                        Console.WriteLine(giro);
                    }
                }

                Console.ReadLine();
            }

            public void VerDinero()
            {
                Console.Clear();

                Console.WriteLine($"Saldo disponible: ${Jugador.Saldo}");

                Console.ReadLine();
            }

            public void Retirarse()
            {
                Console.Clear();

                Console.WriteLine(" RETIRARSE ");
                Console.WriteLine($"Te retiras con ${Jugador.Saldo}");

                Console.ReadLine();
            }
        }
}
