using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problemas_cSharp.GerenciadorDeTarefas
{


    enum PRIORIDADE { Urgente, Importante, Moderada }
    class Tarefa
    {

        public string Nome { get; private set; }
        public PRIORIDADE NivelDePrioridade { get; private set; }


        public Tarefa(string nome, PRIORIDADE prioridade)
        {

            if (string.IsNullOrWhiteSpace(nome))
            {
                throw new ArgumentException("O nome da tarefa não pode ser vazio");
            }

            Nome = nome;
            NivelDePrioridade = prioridade;


        }

        public override string ToString()
        {
            return $"Tarefa: {Nome}  |  Prioridade: {NivelDePrioridade}";

        }



    }
}
