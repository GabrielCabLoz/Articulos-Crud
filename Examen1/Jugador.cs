using System;
using System.Collections.Generic;
using System.Text;

namespace Examen1
{
    internal class Jugador
    {
    public decimal Saldo { get; set; }
        public Jugador()
        {
            Saldo = 300m;
        }

        public void agregarSaldo(decimal cantidad)
        {
            Saldo += cantidad;

        }
        public void quitarSaldo(decimal cantidad)
        {
            Saldo -= cantidad;
        }
    }
}
