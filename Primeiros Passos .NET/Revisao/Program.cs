using System;

namespace Revisao
{
    class Program
    {
        static void Main(string[] args)
        {
            Inicia();
        }

        private static void Inicia()
        {
            Aluno[] alunos = new Aluno[5];
            int indiceAlunos = 0;
            string opcaoUsuario = "";

            while (opcaoUsuario != "X")
            {
                opcaoUsuario = ObtemOpcaoUsuario();

                switch (opcaoUsuario)
                {
                    case "1":
                        System.Console.WriteLine("\nInforme o nome do aluno");
                        Aluno aluno = new Aluno();
                        aluno.Nome = Console.ReadLine();
                        aluno.Nota = -1;
                        
                        while(aluno.Nota == -1)
                        {
                            System.Console.WriteLine("Informe a nota do aluno");
                            if (double.TryParse(Console.ReadLine(), out double notaAluno))
                            {
                                aluno.Nota = notaAluno;
                            }
                            else
                            {
                                System.Console.WriteLine($"Nota deve ser um número decimal");
                            }
                        }

                        alunos[indiceAlunos] = aluno;
                        indiceAlunos++;
                        break;
                    case "2":
                        foreach (var al in alunos)
                        {
                            if (!string.IsNullOrEmpty(al.Nome))
                            {
                                System.Console.WriteLine($"ALUNO: {al.Nome} - NOTA: {al.Nota}");
                            }
                        }
                        break;
                    case "3":
                        if (indiceAlunos == 0)
                        {
                            System.Console.WriteLine("\nAdicione ao menos 1 aluno para calcular a média");
                        }
                        else
                        {
                            double soma = 0;
                            for (int i = 0; i <= indiceAlunos; i++)
                            {
                                soma += alunos[i].Nota;
                            }
                            double media = soma / indiceAlunos;
                            Conceito conceito = media switch
                            {
                                < 2 => Conceito.E,
                                >= 2 and < 4 => Conceito.D,
                                >= 4 and < 6 => Conceito.C,
                                >= 6 and < 8 => Conceito.B,
                                _ => Conceito.A
                            };

                            System.Console.WriteLine($"\nA média geral é {media} e o conceito geral é {conceito}");
                        }
                        break;
                    case "X":

                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                 
            }
        }

        private static string ObtemOpcaoUsuario()
        {
            System.Console.WriteLine("\nInforme a opção desejada:");
            System.Console.WriteLine("1 - Inserir novo aluno");
            System.Console.WriteLine("2 - Listar alunos");
            System.Console.WriteLine("3 - Calcular media geral");
            System.Console.WriteLine("X - Sair");
            System.Console.WriteLine();

            return Console.ReadLine();
        }
    }
}
