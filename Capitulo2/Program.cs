using System;

namespace Capitulo2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, resultado;
            double radiane, grado;
            float euro, dolar, resulta2;

            Console.WriteLine("Calculo de Perimetro\n");
            Console.Write("Dijite la cantidad de lados: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Dijite el tamaño de un lado: ");
            b = int.Parse(Console.ReadLine());
            resultado = a * b;
            Console.Write("Su resultado es:{0}", resultado);

            Console.WriteLine("\n \n Convercion\n");

            Console.Write("Dijite los Grado: ");
            grado = double.Parse(Console.ReadLine());
            radiane = grado * 3.14;
            radiane /= 180;
            Console.Write("Usted tiene {0} Radiane", radiane, "\n \n");

            Console.WriteLine("\n \n Convercion de Divisa\n");

            Console.Write("Dijite el valor del Euro contra el Dolar: ");
            euro = float.Parse(Console.ReadLine());

            Console.Write("Dijite la cantidad de Dolares: ");
            dolar = float.Parse(Console.ReadLine());

            resulta2 = euro * dolar;

            Console.WriteLine("El resultado es: {0}", resulta2);
        }
    }
}
