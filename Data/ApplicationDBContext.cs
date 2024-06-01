using Biblioteca.Models;
using Microsoft.EntityFrameworkCore;

namespace Biblioteca.Data
{
    public class ApplicationDBContext: DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext>options) : base(options)
        {
        }
        //aqui sao criadas as tabelas
        public DbSet<EmprestimoModel> Emprestimos { get; set; }
    }
}
