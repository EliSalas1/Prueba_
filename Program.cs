//Factorial 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Recursividad5
{


    public class Recursividad
    {


        int Factorial(int fact)
        {


            if (fact > 0)
            {
                int valor = fact *Factorial(fact - 1); //Se esta ejecuntado hasta que sea 0
                return valor;
                //[4][3][2][1][0] se va a retornar un valor despues que el metodo termine [0] 
                //[24][6][2][1][1] // se pone el 1 abajo del cero ya que retona ese 1 cuando termine el programa y pasa a la MULTIPLICACIÓN:))
            }
            else
                return 1;
        }

        static void Main(string[] args)
        {
            Recursividad re = new Recursividad();


            int f = re.Factorial(4); //[le pasamos 4 al método]
            Console.WriteLine("El factorial de 4 es " + f);
            Console.ReadKey();
        }
    }
}

