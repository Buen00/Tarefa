using System.Collections.Generic;
using Tarefa.Models;


namespace Tarefa.Models
{
    public interface ICadastroRepository
    {
        void Create(Cadastro cad);
        void Update(Cadastro cad);
        void Delete(int id);
        List<Cadastro> GetAbertas();
        List<Cadastro> GetAll();
        Cadastro GetById(int id);
    }
}