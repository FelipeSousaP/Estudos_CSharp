namespace Recursividade
{
    public class Palindromo
    {
        public bool Verificar(string Palavra, int fim, int Inicio)
        {
            if (Palavra[Inicio] == Palavra[fim]) { return true; }
                return Verificar(Palavra, fim - 1, Inicio + 1);
        }
    }
}
