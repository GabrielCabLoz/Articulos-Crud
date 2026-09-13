using System;
using System.Collections.Generic;
using System.Text;

namespace Examen1
{
    internal class Giro1

    {
        public int numero { get; set; }
        public string color { get; set; }
        public int ParNoPar { get; set; }
      

        public Giro1(int numero, string color, String ParNoPar)
        {
            this.numero = numero;
            this.color = color;
            this.ParNoPar = ParNoPar == "Par" ? 2 : 0;
        }
        public override string ToString()
        {
            return $"Número: {numero}, Color: {color}, Par/No Par: {ParNoPar}";
        }



    }
}


