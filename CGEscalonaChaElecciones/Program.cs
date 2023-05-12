using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGEscalonaChaElecciones
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int i = 0;
            int a = 0, b = 0, c = 0;


            int suma = 0;

            Console.WriteLine("Ingrese Numero de personas");
            int n = int.Parse(Console.ReadLine());

            for (i = 0; i <= n; i++)
            {
                Console.WriteLine("Escribe los votos");
                int voto = int.Parse(Console.ReadLine());
                if (voto >= 1)
                {
                    a += 1;
                }
                else if (voto <= 2)
                {
                    a += 1;
                }
                else
                {
                    c +=3;
                }

            }
            Console.WriteLine("Total de votos del candidato 1 es : " + a);

            Console.WriteLine("Total de votos del candidato 2 es " + b);
            Console.WriteLine("Total de votos del candidato 3 es " + c);
            
            Console.ReadKey();






            //Candidatos candidatos = new Candidatos();
            //int i = 0;
            //int a = 0, b = 0, c = 0;
            //bool salir = false;
            //while (!salir)
            //{
            //    Console.WriteLine("Bienvenido al Menu");
            //    Console.WriteLine("1. Candidato 1 ");
            //    Console.WriteLine("2. Candidato 2 ");
            //    Console.WriteLine("3. Candidato 3 ");
            //    Console.WriteLine("4. Salir");

            //    int opcion = Convert.ToInt32(Console.ReadLine());

            //    switch (opcion)
            //    {
            //        case 1:
            //            Console.WriteLine();
            //            if (a <= 0)
            //            {
            //                Console.WriteLine("Voto por el 1 candidato");
            //                Console.WriteLine();
            //            }


            //            break;
            //        case 2:
            //            Console.WriteLine();
            //            if (b <= 0)
            //            {
            //                Console.WriteLine("Voto por el 1 candidato");
            //                Console.WriteLine();
            //            }


            //            break;
            //        case 3:
            //            Console.WriteLine();
            //            if (c <= 0)
            //            {
            //                Console.WriteLine("Voto por el 1 candidato");
            //                Console.WriteLine();
            //            }


            //            break;
            //        case 4:
            //            Console.WriteLine();
            //            if (c <= 0)
            //            {
            //                Console.WriteLine("Resultado ");
            //                Console.WriteLine();
            //            }


            //            break;
            //        case 5:
            //            Console.WriteLine("Has elegido salir de la aplicación");
            //            salir = true;
            //            break;
            //        default:
            //            Console.WriteLine("Elige una opcion entre 1 y 4");
            //            break;
            //    }

            //}


            //Console.ReadKey();
            //for (i = 0; i <= a; i++)
            //{
            //    Console.WriteLine("Ingresa su cadidato");
            //    int candidato = int.Parse(Console.ReadLine());
            //    Console.WriteLine();
            //    if (i <= 0)
            //    {
            //        Console.WriteLine("Voto por el 1 candidato");
            //        Console.WriteLine();
            //    }
            //    else if (i <= b)
            //    {
            //        Console.WriteLine("Voto por el 2 canidato");
            //        Console.WriteLine();
            //    }
            //    else if (i >= b && i < c)
            //    {
            //        Console.WriteLine("Voto por el 3 candidato");
            //        Console.WriteLine();
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine();


            //var fibNumbers = new List<int> { 0, 1, 1, 2, 3, 5, 8, 13 };
            //Console.WriteLine("Ingresa su cadidato");
            //if(i <= 0)
            //{
            //    Console.WriteLine("Voto por el 1 candidato");
            //    Console.WriteLine();
            //}
            //else if (i <= b)
            //{
            //    Console.WriteLine("Voto por el 2 canidato");
            //    Console.WriteLine();
            //}
            //else if(i >= b && i < c)
            //{
            //    Console.WriteLine("Voto por el 3 candidato");
            //    Console.WriteLine();
            //}
            //Console.WriteLine();
        }
    }
}
