using Microsoft.EntityFrameworkCore;

namespace Tarefa.Models
{

    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base (options)
        {
        }

        public DbSet<Cadastro> tarefas {get; set;}
    }
}
