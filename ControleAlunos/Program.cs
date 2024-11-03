using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleAlunos
{
    internal class Program
    {
        private static List<Aluno> listaAlunos = new List<Aluno>();
        static void Main(string[] args)
        {
            int opcao;

            do
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1 - Cadastrar Aluno");
                Console.WriteLine("2 - Exibir Situações");
                Console.WriteLine("0 - Sair");
                Console.Write("Escolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        CadastrarAluno();
                        break;
                    case 2:
                        ExibirSituacoes();
                        break;
                    case 0:
                        Console.WriteLine("Saindo...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            } while (opcao != 0);
        }

        private static void CadastrarAluno() { 
        
            Aluno aluno = new Aluno();

            Console.Write("Digite o RA do aluno: ");
            aluno.RA = Console.ReadLine();

            Console.Write("Digite o nome do aluno: ");
            aluno.Nome = Console.ReadLine();

            for (int i = 0; i < 4; i++)
            {
                Console.Write($"Digite a nota {i + 1}: ");
                aluno.Notas[i] = double.Parse(Console.ReadLine());
            }

            listaAlunos.Add(aluno);
            Console.WriteLine("Aluno cadastrado com sucesso!\n");
        }

        private static void ExibirSituacoes()
        {
            Console.WriteLine("\nSituação dos Alunos:");

            foreach (Aluno aluno in listaAlunos)
            {
                double media = aluno.CalcularMedia();
                string situacao;

                if (media >= 6)
                {
                    situacao = "Aprovado";
                }
                else if (media >= 4)
                {
                    situacao = "Recuperação";
                }
                else
                {
                    situacao = "Reprovado";
                }

                Console.WriteLine($"RA: {aluno.RA}, Nome: {aluno.Nome}, Média: {media:F2}, Situação: {situacao}");
            }
            Console.WriteLine();
        }
    }
}

