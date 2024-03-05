namespace Fibonacci
{
    internal class Program
    {
        static List<int> Fibonacci(int n)
        {
            List<int> sequenciaFib = new List<int> { 0, 1 };
            while (sequenciaFib.Count < n)
            {
                int proximo = sequenciaFib[sequenciaFib.Count - 1] + sequenciaFib[sequenciaFib.Count - 2];
                sequenciaFib.Add(proximo);
            }
            return sequenciaFib;
        }

        static void Main()
        {
            int n = 10;
            List<int> resultado = Fibonacci(n);
            Console.WriteLine($"Sequência de Fibonacci com {n} elementos: ");
            foreach (int num in resultado)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}

