using System.Collections;

namespace problemas_cSharp.GerenciadorDeTarefas;

public class Tarefa
{

    
    public ArrayList listaTarefas = new ArrayList();
    
 
    public void adiciona() 
    {
        Console.WriteLine("Digite o nome da tarefa:");
        string nome = Console.ReadLine();

        listaTarefas.Add(nome);
        
    }
    
 
    public void listarTarefas()
    {
        if (listaTarefas.Count > 0)
        {
            Console.WriteLine();
            foreach (string tarefa in listaTarefas)
            {
                Console.Write(tarefa + " | ");
            }   
            
        }
        else
        {
            Console.WriteLine("Sua lista não possui nenhuma tarefa");
        }
        
        
        
    }
    
    

    public void removerTarefa()
    {
        Console.WriteLine("Digite o nome da tarefa que deseja remover: :");
        string nome = Console.ReadLine();

        if (listaTarefas.Contains(nome))
        {
            listaTarefas.Remove(nome);
            Console.WriteLine("Tarefas removido com sucesso!");
            
        }
        
        Console.WriteLine("A tarefa digitada não foi encontrada!");
        
    }
    
    
    
    
    
    
    
    
    
    
    
    
    








}