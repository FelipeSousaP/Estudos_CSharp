namespace Recursividade
{
    public class Fatorial
    {
        public static int Calcularfatorial(int n)
        {
            int num = 1;// Numero que  conterá a Multiplicação
            for (int i = 1; i < n + 1; i++) 
            {
                num *= i; // numero atual da repetição x o fatorial total
            /*
             1 * 1 = 1
             1 * 2 = 2
             2 * 3 = 6
             6 * 4 = 24
             24 * 5 = 120
             */
            }
            return num;
        }

        public static int CalcularComRecursividade(int num)
        {
            if (num == 0) 
            {
                return 1;
            }
            // Ele faz a fatorial so que ao contrário
            return num * CalcularComRecursividade(num - 1);
        }
    }
}
