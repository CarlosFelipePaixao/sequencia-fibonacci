using System;


namespace SequenciaFibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Informe um número: ");
            int numero = int.Parse(Console.ReadLine());

            if (PertenceSequenciaFibonacci(numero))
            {
                Console.WriteLine($"{numero} pertence à sequência de Fibonacci.");
            }
            else
            {
                Console.WriteLine($"{numero} não pertence à sequência de Fibonacci.");
            }

            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }

        static bool PertenceSequenciaFibonacci(int numero)
        {
            if (numero == 0 || numero == 1)
            {
                return true;
            }

            int a = 0, b = 1, c = 0;

            while (c < numero)
            {
                c = a + b;
                a = b;
                b = c;
            }

            return c == numero;



        }
    }
}
