using System;
using System.Globalization;

namespace catetosehipotenusa
{
    class Program
    {
        public static void Main()
        {
            CalcularHipotenusa();
        }

        private static void CalcularHipotenusa()
        {
            string cateto1;
            string cateto2;
            double hipotenusa;
            double hipotenusacuadrada;

            Console.Write("Ingrese el primer cateto:");
            cateto1 = Console.ReadLine();
            Console.Write("Ingrese el segundo cateto:");
            cateto2 = Console.ReadLine();

            if (IsNumber(cateto1) && IsNumber(cateto2)) 
            {
                double x = Convert.ToDouble(cateto1);
                double y = Convert.ToDouble(cateto2);

                hipotenusacuadrada = (x * x) + (y * y);
                hipotenusa = Math.Sqrt((x * x) + (y * y));

                Console.WriteLine("La hipotenusa es:{0} y la hipotenusa al cuadrado es {1}", hipotenusa, hipotenusacuadrada);
            }
            else
            {
                Console.WriteLine("Ingrese números");
                Main();
            }
        }
        public static bool IsNumber(string numer1) //es para asegurar que se introzca un número.
        {
            bool isnumber;
            CultureInfo culture = new CultureInfo("en-US");
            try
            {
                Convert.ToDouble(numer1, culture);
                isnumber = true;
            }
            catch
            {
                isnumber = false;
            }
            return isnumber;
        }
    }
}
