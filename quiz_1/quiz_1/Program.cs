using System;

namespace quiz_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = 0;
            String entrada = "";

            Console.Write("Ingrese el numero que desea: ");
            entrada = Console.ReadLine();
            num = Convert.ToDouble(entrada);
            if (num >= 0)
            {
                Console.Write("EL NUMERO: {0}, ES POSITIVO",num);
            }
            else
            {
                Console.Write("EL NUMERO: {0}, ES NEGATIVO",num);
            }
            Console.ReadKey();
        }
    }
}
