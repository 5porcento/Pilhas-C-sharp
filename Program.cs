Stack<int> pilha = new Stack<int>();

pilha.Push(0);
pilha.Push(1);
pilha.Push(2);
pilha.Push(3);
pilha.Push(4);

foreach (int itens in pilha)
{
    Console.WriteLine(itens);
}
Console.WriteLine($"Removendo o elemento: {pilha.Pop()}");
pilha.Push(5);

foreach (int itens in pilha) {
    Console.WriteLine(itens); }