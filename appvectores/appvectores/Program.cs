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
            vectorinicial ();

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
       public static void vectorinicial (){
            
            int [] x=new int[8];
            x[0]=10;
            x[1]=10;
            x[2]=10;
            x[3]=10;
            x[4]=10;
            x[5]=10;
            x[6]=10;
            x[7]=10;
            Console.WriteLine ("\nElEmentos del vector\n=====================");
            for (int i=0;i<8;i++){
                
                Console.WriteLine("elemento indice {0} --> {1}", (i + 1), x[i]);

            }

            int s=0;
            for (int i=0;i<x.Length;i++){
                s+=x[i];

            }
            Console.WriteLine ("la sumatoria es {0}", s );
                Console.WriteLine("el pro,edio es  {0}", (double )s/x.Length );
}

        
           

        
    }
}
