namespace Filas
{
    public class Fila<T>
    {
        Node<T>? Primeiro;
        Node<T>? Ultimo;
        int Tamanho;
        
        public Fila(Node<T>? node)
        {
            Adicionar(node);
        }

        // 3. adicionar
        public void Adicionar(Node<T>? node)
        {
            // 1. saber se o primeiro é nulo
            if (Primeiro == null)
            {
                //o mesmo valor em duas variaveis
                Primeiro = node; //guardando o valor no primeiro
                Ultimo = node;
            }
            else
            {
                Ultimo?.SetNext(node); //Adiciono o Node no fim da fila
                Ultimo = node; // Atualizar atual como ultimo
            }

            Tamanho++;
        }

        // 4. tirar o que esta na frente da fila
        public Node<T>? Retirar()
        {
            if (Tamanho == 0) return null;
            
            // criar uma variavel que vai conter nada
            var Temp = Primeiro;
            
            //Por não poder apontar pra algo, ele vai desaparecer
            Primeiro = Temp.GetPointer; // Assim perdendo o primeiro no sistema
            Tamanho--;
            return Temp;
        }

        // 5. mostra o que está na frente da fila
        public Node<T>? PrimeroDaFila() => Primeiro;
        public int Count => Tamanho;
    }
}
