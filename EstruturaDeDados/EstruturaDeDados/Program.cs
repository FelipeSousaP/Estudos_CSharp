using Filas;

Node<int> item = new Node<int>(2);
Fila<int> minhafila = new Fila<int>(item);

// {0} isso é importante
Console.WriteLine("Fila");
Console.WriteLine("tamanho da fila: {0}", minhafila.Count);
Console.WriteLine("Adicionando 6 números na lista");

minhafila.Adicionar(new Node<int>(3));
minhafila.Adicionar(new Node<int>(4));
minhafila.Adicionar(new Node<int>(5));
minhafila.Adicionar(new Node<int>(6));
minhafila.Adicionar(new Node<int>(7));
minhafila.Adicionar(new Node<int>(8));

Console.WriteLine("Mostrar primeiro da fila: {0}", minhafila.PrimeroDaFila()?.item);
Console.WriteLine("Retira o primeiro da lista {0}", minhafila.Retirar()?.item);

Console.WriteLine("Mostrar primeiro da fila: {0}", minhafila.PrimeroDaFila()?.item);
Console.WriteLine("Retira o primeiro da lista {0}", minhafila.Retirar()?.item);

Console.WriteLine("Mostrar primeiro da fila: {0}", minhafila.PrimeroDaFila()?.item);
Console.WriteLine("Retira o primeiro da lista {0}", minhafila.Retirar()?.item);

Console.WriteLine("Mostrar primeiro da fila: {0}", minhafila.PrimeroDaFila()?.item);
Console.WriteLine("Retira o primeiro da lista {0}", minhafila.Retirar()?.item);

Console.WriteLine("Mostrar primeiro da fila: {0}", minhafila.PrimeroDaFila()?.item);
Console.WriteLine("Retira o primeiro da lista {0}", minhafila.Retirar()?.item);

Console.WriteLine("Mostrar primeiro da fila: {0}", minhafila.PrimeroDaFila()?.item);
