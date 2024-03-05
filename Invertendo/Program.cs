namespace Invertendo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Coloque um array de caracteres denominado A, B, C, D e E em ordem inversa.\n");

            char[] arrayCaracteres = { 'A', 'B', 'C', 'D', 'E' };
            char[] arrayCaracteresInverso = new char[arrayCaracteres.Length];

            int comecoArray = 0;
            int fimArray = arrayCaracteres.Length - 1;

            while (comecoArray <= fimArray)
            {
                arrayCaracteresInverso[comecoArray] = arrayCaracteres[fimArray];
                arrayCaracteresInverso[fimArray] = arrayCaracteres[comecoArray];

                comecoArray++;
                fimArray--;
            }

            Console.WriteLine("O array invertido fica: ");
            foreach (var elemento in arrayCaracteresInverso)
            {
                Console.Write(elemento + " ");
            }
            Console.WriteLine();
        }
    }
}

