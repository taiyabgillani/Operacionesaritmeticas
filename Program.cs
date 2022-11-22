using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operacionesaritmeticas
{
    class Program
    {
        static void Main(string[] args)
        {
            //AREA DE CUADRADO
            Console.WriteLine("                                   Operaciones Aritmeticas");
            Console.WriteLine("\n                                       Area de Cuadrado");
            int L1;

            Console.WriteLine("\nIntroduzca el valor de lado ");
            L1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("El area de Cuadrado = " + Math.Pow(L1, 2));

            
            //AREA DE RECTANGULO
            Console.WriteLine("\n                                       Area de Rectangulo ");
            int Base1;
            int Altura1;
            Console.WriteLine("Introduzca el valor de base ");
            Base1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduzca el valor de altura ");
            Altura1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("El area de Rectangulo = " + Base1 * Altura1);


            //AREA DE TRIANGULO
            Console.WriteLine("\n                                       Area de Triangulo ");
            int Base2;
            int Altura2;
            Console.WriteLine("Introduzca el valor de base ");
            Base2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduzca el valor de altura ");
            Altura2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("El area de Triangulo = " + (Base2 * Altura2)/2);

           


            //AREA DE CIRCULO
            
            Console.WriteLine("\n                                       Area de Circulo");
            int r;
            Console.WriteLine("\nIntroduzca el valor de radius ");
            r = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("El area de Circulo = " + 3.1416* Math.Pow(r, 2));

            //AREA DE CONO
            Console.WriteLine("\n                                       Area de Cono ");
            int rad;
            int alt;
            Console.WriteLine("Introduzca el valor de radius ");
            rad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduzca el valor de altura ");
            alt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("El area de Cono = " + (rad* alt) * 3.1416);







            //BUSCAR HIPOTENUSA
            Console.WriteLine("\n                                       Encuentre Hipotenusa ");
            
            int a;
            int b;
            
            Console.WriteLine("Introduzca el valor de cateto 1 ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduzca el valor de cateto 2 ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("La Hipotenusa = " +  (Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2))) );


            //AREA DE TRAPECIO
            Console.WriteLine("\n                                       Area de Trapecio ");
            int Base3;
            int base3;
            int Altura3;
            Console.WriteLine("Introduzca el valor de Base grande ");
            Base3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduzca el valor de Base chiquita ");
            base3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduzca el valor de altura ");
            Altura3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("El area de Trapecio = " + ((Base3 + base3)) * Altura3 / 2);

            //AREA DE HEXAGONO
            Console.WriteLine("\n                                       Area de Hexagono ");
            int Perimetro;
            int Apotema;
            Console.WriteLine("Introduzca el valor de Perimetro ");
            Perimetro = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduzca el valor de Apotema ");
            Apotema = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("El area de Hexagono = " + (Perimetro * Apotema) / 2);


            //AREA DE ELIPSE
            Console.WriteLine("\n                                       Area de Elipse ");
            int D1;
            int D2;
            Console.WriteLine("Introduzca el valor de Distanicia 1 ");
            D1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduzca el valor de Distancia 2 ");
            D2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("El area de Elipse = " + (D1 * D2) * 3.1416);






            Console.ReadKey();



        }
    }
}
