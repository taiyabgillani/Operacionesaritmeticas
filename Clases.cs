using System;


namespace Ope
{
    public class Clases
    {
        static void Main(string[] args)
        {
        }

        public static double AreaCuadrado(int L1)
        {
            Console.WriteLine("                                   Operaciones Aritmeticas");
            Console.WriteLine("\n                                       Area de Cuadrado");

            Console.WriteLine("El area de Cuadrado = " + Math.Pow(L1, 2));

            return Math.Pow(L1, 2);
        }

        public static double AreaRectangulo(int Base1, int Altura1)
        {
            Console.WriteLine("\n                                       Area de Rectangulo ");
            
            
            Console.WriteLine("El area de Rectangulo = " + Base1 * Altura1);


            return Base1 * Altura1;
        }

        public static double AreaTriangulo(int Base2, int Altura2)
        {
            Console.WriteLine("\n                                       Area de Triangulo ");


            Console.WriteLine("El area de Triangulo = " + (Base2 * Altura2) / 2);

            return (Base2 * Altura2)/2;

        }

        public static double AreaCirculo(int r)
        {

            Console.WriteLine("\n                                       Area de Circulo");

           
            Console.WriteLine("El area de Circulo = " + 3.1416 * Math.Pow(r, 2));


            return 3.1416 * Math.Pow(r, 2);
        }

        public static double AreaCono(int rad, int alt)
        {

            Console.WriteLine("\n                                       Area de Cono ");


            Console.WriteLine("El area de Cono = " + (rad * alt) * 3.1416);

            return (rad * alt) * 3.1416;
        }

        public static double AreaHipotenusa(int a, int b)
        {

            Console.WriteLine("\n                                       Encuentre Hipotenusa ");


            Console.WriteLine("La Hipotenusa = " + (Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2))));

            return (Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2)));
        }
        
        public static double AreaTrapecio(int Base3, int base3, int Altura3)
        {

            Console.WriteLine("\n                                       Area de Trapecio ");
 
            Console.WriteLine("El area de Trapecio = " + ((Base3 + base3)) * Altura3 / 2);

            return (Base3 + base3) * Altura3 / 2;
        }
        public static double AreaHexagono(int Perimetro, int Apotema)
        {

            Console.WriteLine("\n                                       Area de Hexagono ");
           
            Console.WriteLine("El area de Hexagono = " + (Perimetro * Apotema) / 2);


            return (Perimetro * Apotema) / 2;
        }
        public static double AreaElipse (int D1, int D2)
        {
            Console.WriteLine("\n                                       Area de Elipse ");
            
            Console.WriteLine("El area de Elipse = " + (D1 * D2) * 3.1416);

            return (D1 * D2) * 3.1416;
        }
    }
}
