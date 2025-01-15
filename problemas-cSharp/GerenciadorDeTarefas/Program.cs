
namespace problemas_cSharp.GerenciadorDeTarefas;
    public class Program
    {
        public static void Main(string[] args)
        {
            Tarefa tarefa = new Tarefa();
            int opcao;
            do
            {
                Console.WriteLine("===============================================");
                Console.WriteLine("           MENU DE CONTROLE DE ROTINA        ");
                Console.WriteLine("===============================================");
                Console.WriteLine("1 - Adicionar uma nova tarefa");
                Console.WriteLine("2 - Listar suas tarefas");
                Console.WriteLine("3 - Remover uma tarefa da lista");
                Console.WriteLine("0 - Sair");
                
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        tarefa.adiciona();
                        break;
                    
                    case 2:
                        tarefa.listarTarefas();
                        break;
                    
                    case 3:
                        tarefa.removerTarefa();
                        break;
                    
                    default:
                        Console.WriteLine("Opção invalida!");
                        break;
                }
                
            } while (opcao != 0);
            
           
            
            
            
            
            
        }
        
    
    }