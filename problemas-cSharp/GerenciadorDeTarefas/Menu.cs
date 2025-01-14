using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problemas_cSharp.GerenciadorDeTarefas
{
    public class Menu
    {
        private List<Tarefa> tarefas;

        public Menu()
        {

            tarefas = new List<Tarefa>();


        }



        // Método para exibir o menu e gerenciar a interação com o usuário
        public void ExibirMenu()
        {
            int opcao;

            do
            {
                Console.WriteLine("\n==== Gerenciador de Tarefas ====");
                Console.WriteLine("1 - Adicionar Tarefa");
                Console.WriteLine("2 - Listar Tarefas");
                Console.WriteLine("3 - Sair");
                Console.Write("Escolha uma opção: ");
                opcao = int.Parse(Console.ReadLine() ?? "0");

                switch (opcao)
                {
                    case 1:
                        AdicionarTarefa();
                        break;
                    case 2:
                        ListarTarefas();
                        break;
                    case 3:
                        Console.WriteLine("Saindo...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida! Tente novamente.");
                        break;
                }
            } while (opcao != 3);
        }



        private void AdicionarTarefa()
        {
            Console.WriteLine("\nQual o nome da tarefa?");
            string nome = Console.ReadLine();

            Console.WriteLine("Escolha a prioridade da tarefa:");
            Console.WriteLine("0 - Urgente");
            Console.WriteLine("1 - importante");
            Console.WriteLine("2 - Moderado");

            Console.Write("Digite ==> ");
            int prioridades = int.Parse(Console.ReadLine());

            //Convertendo a entrada para o enum Prioridade
            if (Enum.IsDefined(typeof(PRIORIDADE), prioridades))
            {
                PRIORIDADE prioridade = (PRIORIDADE)prioridades;

                Tarefa novaTarefa = new Tarefa(nome, prioridade);
                Console.WriteLine("Tarefa Adicionada com sucesso!");
            }
            else
            {
                Console.WriteLine("Prioridade inválida!");
            }
        }


        private void ListarTarefas()
        {
            if (tarefas.Count == 0)
            {
                Console.WriteLine("Nenhuma tarefa cadastrada");

            }
            else
            {

                foreach (Tarefa tarefa in tarefas)
                {
                    Console.Write(tarefa + " ");

                }

            }
        }




    }
}
