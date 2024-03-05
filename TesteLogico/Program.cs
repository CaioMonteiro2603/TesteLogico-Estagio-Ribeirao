namespace LacoRepeticao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int indice = 13;
            int soma = 0;
            int k = 0;

            while(k < indice)
            {
                k += 1;
                soma += k;


                Console.WriteLine("O valor da soma é: " + soma); 
            }
        }
    }
}
