using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appvectores
{
    class Program

    {
        const int MAX = 10;
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
            
            Tarea();
            Console.WriteLine("El numero mayor es: " + mayor);

			Console.WriteLine("El numero menor es: " + menor);

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

        public static void Tarea()

		{

			int[] ve = new int[10];

			int mayor = ve[0], menor = ve[0];


			for (int i = 0; i < ve.Length; i++)

			{

				while (ve[i] < 1 || ve[i] > 1000)

				{

					Console.WriteLine("Ingrese un valor {0} ", i + 1);

					ve[i] = Int32.Parse(Console.ReadLine());

				}


			}

			for (int i = 0; i < ve.Length; i++)

			{

				if (ve[i] > mayor)

				{

					mayor = ve[i];

				}

			}

			menor = mayor;

			for (int i = 0; i < ve.Length; i++)

			{

				if (ve[i] < menor)

				{

					menor = ve[i];

				}

			}

            

			
            Console.ReadKey ();
		}
           
        static void Main(string[] args)
        {
            int[] x = new int[MAX];
            string[] nombres = new string[MAX];
            
            leer(x);
            imprimir(x);
            ordenar(x);
            Console.WriteLine("Vector Ordenar");
            imprimir(x);

            if (buscar(x, 15))
                Console.WriteLine("\n15 ENCONTRADO");
            else
                Console.WriteLine("\n15 NO ENCONTRADO");

            if (buscar2(x, 25))
                Console.WriteLine("\n25 ENCONTRADO");
            else
                Console.WriteLine("\n25 NO ENCONTRADO");
            
            Console.WriteLine("\nIngrese los nombres");
            leerNombres(nombres);
            imprimirNombres(nombres);

            ordenarNombres(nombres);
            Console.WriteLine("Vector Ordenar");
            imprimirNombres(nombres);
            Console.ReadKey();




        }
        public static void leer(int[] x)
        {
            for (int i = 0; i < MAX; i++)
            {
                Console.WriteLine("\nIngrese el elemento{0}", i + 1);
                x[i] = Int32.Parse(Console.ReadLine());

            }
        }

        public static void imprimir(int[] x)
        {
            foreach (int num in x)
            {
                Console.WriteLine("\nElemento {0}", num);
            }
        }

        public static bool buscar(int[] x, int y)

        {
            bool encontrado = false;
            foreach (int num in x)
            {
                if (num == y)
                {
                    encontrado = true;
                    break;
                }
            }
            return encontrado;



        }

        public static bool buscar2(int[] x, int y)
        {
            bool encontrado = false;
            int i = 0;
            while (i < MAX && encontrado == false)
            {
                if (x[i] == y)
                    encontrado = true;
                i++;
            }
            return encontrado;
        }

        public static void ordenar(int[] x)
        {
            int aux = 0;
            for (int i = 0; i < x.Length; i++)
                for (int j = i + 1; j < (x.Length); j++)

                    if (x[i] > x[j])
                    {
                        aux = x[i];
                        x[i] = x[j];
                        x[j] = aux;
                    }
        }




        public static void leerNombres(string[] x)
        {
            for (int i = 0; i < MAX; i++)
            {
                Console.WriteLine("\nIngrese el elemento{0}", i + 1);
                x[i] = Console.ReadLine();

            }
        }
        public static void OrdenarNombres(string[] x)
        {
            string aux = "";
            for (int i = 0; i < x.Length; i++)
                for (int j = i + 1; j < x.Length; j++)
                    if (String.Compare(x[i], x[j], StringComparison.Ordinal) > 0)
                    { //ingresar el elemento del vector
                        aux = x[i];
                        x[i] = x[j];
                        x[j] = aux;
                    }


        }
        public static void ordenarNombres(string[] x)
        {
            string aux = "";
            for (int i = 0; i < x.Length; i++)
            {
                for (int j = i; j < x.Length; j++)
                {
                    if (String.Compare(x[i], x[j], StringComparison.Ordinal) > 0)
                    {
                        aux = x[i];
                        x[i] = x[j];
                        x[j] = aux;
                    }
                }
            }
        }

        public static void imprimirNombres(string[] x)
        {
            foreach (string num in x)
            {
                Console.WriteLine("\nNombre: {0}", num);
            }
        }

    }

        }
    }
}
