using System;

namespace Tarefa.Models
{
    public class Cadastro
    {
        public Cadastro(){}

        public Cadastro(int id, float prioridade, string nameTarefa, string data, int percent)
        {
            this.id=id;
            this.prioridade = prioridade;
            this.nameTarefa = nameTarefa;
            this.data = data;
            this.percent = percent;
        }
        public int id {get; set;}
        public float prioridade { get; set; }
        public string nameTarefa { get; set; }

        public string data { get; set; }     
        public int percent {get; set;}   

    }    
}
