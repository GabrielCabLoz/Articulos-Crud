using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Examen1
{
    internal class Ruleta
    {
        Random random = new Random();
        int[] negros = [ 2,4,6,8,10,11,13,15,17,20,22,24,26,28,29,31,33,35];

        int[] rojos = [ 1,3,5,7,9,12,14,16,18,19,21,23,25,27,30,32,34,36];

        int[] azules = [0];

        public Giro1 girar()
        {
            int numero = random.Next(0, 37);

            string color = "Sin color";


            if (rojos.Contains(numero))
                color = "Rojo";

            if (negros.Contains(numero))
                color = "Negro";

            if (azules.Contains(numero))
                color = "Azul";

            string parNopar = "Niguno";

            if (numero != 0)
            {
                parNopar = (numero % 2 == 0) ? "par" : "impar";


          
        }
            return new Giro1(numero, color, parNopar);






        }
}
}
