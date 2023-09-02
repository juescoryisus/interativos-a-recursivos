using System;

class Program
{
    static int CalcularFactorial(int n)
    {
        if (n == 0)
        {
            return 1;
        }
        else
        {
            return n * CalcularFactorial(n - 1);
        }
    }
    static void Main()
    {
        try
        {
            Console.Write("Ingrese un número para calcular su factorial: ");
            int n = int.Parse(Console.ReadLine());

            if (n < 0)
            {
                Console.WriteLine("El factorial no está definido para números negativos.");
            }
            else
            {
                int resultado  = CalcularFactorial(n);
                Console.WriteLine($"El factorial de {n} es {resultado}");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Por favor, ingrese un número válido.");
        }
        Console.ReadKey();
    }
}
