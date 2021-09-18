using System;
using EstruturaDoPrograma.Exemplos;

namespace EstruturaDoPrograma
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Pilha();
            s.Empilha(1);
            s.Empilha(10);
            s.Empilha(100);
            System.Console.WriteLine(s.Desempilha());
            System.Console.WriteLine(s.Desempilha());
            System.Console.WriteLine(s.Desempilha());
            System.Console.WriteLine(s.Desempilha());
        }
    }
}
