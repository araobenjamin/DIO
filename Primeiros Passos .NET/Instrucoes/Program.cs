using System;

namespace Instrucoes
{
    class Program
    {
        static void Declaracoes()
        {
            int a;
            a = 1;
            int b = 2;
            int c = 3;
            const int d = 4;
            System.Console.WriteLine(a + b + c + d);
        }
        
        static void InstrucaoIf(string[] args)
        {
            if (args.Length == 0)
            {
                System.Console.WriteLine("Nenhum argumento");
            }
            else if (args.Length == 1)
            {
                System.Console.WriteLine("1 argumento");
            }
            else
            {
                System.Console.WriteLine($"{args.Length} argumentos");
            }
        }

        static void InstrucaoSwitch(string[] args)
        {
            int numeroDeArgumentos = args.Length;

            switch (numeroDeArgumentos)
            {
                case 0:
                    System.Console.WriteLine("Nenhum argumento");
                    break;
                case 1:
                    System.Console.WriteLine("1 argumento");
                    break;
                default:
                    System.Console.WriteLine($"{numeroDeArgumentos} argumentos");
                    break;
            }
        }

        static void InstrucaoWhile(string[] args)
        {
            int i = 0;

            while (i < args.Length)
            {
                 System.Console.WriteLine(args[i]);
                 i++;
            }
        }

        static void InstrucaoDo(string[] args)
        {
            string texto;

            do
            {
                texto = Console.ReadLine();
                System.Console.WriteLine(texto);
            } while (!string.IsNullOrEmpty(texto));
        }

        static void InstrucaoFor(string[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                System.Console.WriteLine(args[i]);
            }
        }

        static void InstrucaoForeach(string[] args)
        {
            foreach (string s in args)
            {
                System.Console.WriteLine(s);
            }
        }

        static void InstrucaoBreak(string[] args)
        {
            while (true)
            {
                 string s = Console.ReadLine();

                 if (string.IsNullOrEmpty(s))
                 {
                     break;
                 }

                 System.Console.WriteLine(s);
            }
        }

        static void InstrucaoContinue(string[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                if (args[i].StartsWith("/"))
                {
                    continue;
                }

                System.Console.WriteLine(args[i]);
            } 
        }

        static void InstrucaoReturn(string[] args)
        {
            if (args.Length == 0)
            {
                return;
            }

            int Somar(int a, int b)
            {
                return a + b;
            }

            System.Console.WriteLine(Somar(1,2));
            System.Console.WriteLine(Somar(3,4));
            System.Console.WriteLine(Somar(5,6));
        }

        static void InstrucaoTryCatchFinallyThrow(string[] args)
        {
            double Dividir(double x, double y)
            {
                if (y == 0)
                    throw new DivideByZeroException();
                
                return x / y;
            }

            try
            {
                if (args.Length != 2)
                {
                    throw new InvalidOperationException("Informe 2 números");
                }

                double x = double.Parse(args[0]);
                double y = double.Parse(args[1]);
                System.Console.WriteLine(Dividir(x, y));
            }
            catch (InvalidOperationException e)
            {
                System.Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                System.Console.WriteLine($"Erro genérico: { e.Message }");
            }
            finally
            {
                System.Console.WriteLine("Até breve!");
            }
        }

        static void InstrucaoUsing(string[] args)
        {
            using (System.IO.TextWriter w = System.IO.File.CreateText("teste.txt"))
            {
                 w.WriteLine("Linha 1");
                 w.WriteLine("Linha 2");
                 w.WriteLine("Linha 3");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
