
namespace Filas
{
    public class Node<T> 
    {
        // valor generico
        public T item;
       
        // contem o ponteiro
        Node<T>? pointer = null;

        // valor recebido ao construir um Nó
        public Node(T _item)
        {
            item = _item;
        }

        #pragma warning disable CS8603 // Possível retorno de referência nula.
        
        public Node<T> GetPointer { get { return pointer; } }

        /*/// <summary>
        /// <para>
        /// Registra a referência para o nó anterior.
        /// </para>
        /// <paramref name="_pointer"/> - Referência para o nó anterior.
        /// </summary>*/
        public void SetNext(Node<T>? _pointer)
        {
            pointer = _pointer;
        }
    }
}
