using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appvectores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("control de versiones kl");
            Console.WriteLine("control de versiones1");
            Console.WriteLine("3 elevado a la 4 es igual a {0}", potencia(3, 4));
            try
            {
                Console.WriteLine("-5 elevado a la 2 es igual a {0}", potencia(-5, 2));
            }catch (Exception ex)
            {
                Console.WriteLine("error :" + ex.Message.ToString());
            }
            Console.WriteLine("2 elevado a la 5 es igual a {0}", potencia(2, 5));

            Console.ReadKey();
        }
        public static double potencia (double x, int  y)
        {
            double p = 1;
            if (x <= 0)
            {
                throw new Exception ("x debe de ser positivo... ");
            }
            if (y <= 0)
            {
                throw new Exception("y debe de ser positivo");
            }
            for (int i = 1; i < y; i++)
            {
                p *= y;

            }
            return p;
        }
       
        
           

        
    }
}
