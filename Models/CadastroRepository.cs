using System.Collections.Generic;
using System.Linq;


namespace Tarefa.Models
{
    public class CadastroRepository : ICadastroRepository
    {
    
        private DataContext context;
        public CadastroRepository(DataContext context){
            this.context = context;
        }
    
        public CadastroRepository()
        {           
        }

        public void Create(Cadastro cad)
        {
            context.tarefas.Add(cad);
            context.SaveChanges();
        }
        public List<Cadastro> GetAll()
        {
            return context.tarefas.ToList();
        }

         public List<Cadastro> GetAbertas()
        {
            return context.tarefas.Where(x=>x.percent < 100).ToList();
        }

         public List<Cadastro> GetPorcento()
        {
            return context.tarefas.Where(x=>x.percent == 100).ToList();
        }
        
        public Cadastro GetById(int id)
        {
            return context.tarefas.SingleOrDefault(x=>x.id == id);
        }
        
        public void Delete(int id)
        {
            context.tarefas.Remove(GetById(id));
            context.SaveChanges();

        }
        public void Update(Cadastro cad)
        {
            var objOrigem = GetById(cad.id);
            objOrigem.prioridade = cad.prioridade;
            objOrigem.nameTarefa = cad.nameTarefa;
            objOrigem.data = cad.data;
            objOrigem.percent = cad.percent;
            context.SaveChanges();
        }

        
    }
    }