using Microsoft.EntityFrameworkCore;

namespace tarefa_ronan_1.Infrastructure
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {

        public DbSet<Produto.Produto> Produtos => Set<Produto.Produto>();
    }
}
