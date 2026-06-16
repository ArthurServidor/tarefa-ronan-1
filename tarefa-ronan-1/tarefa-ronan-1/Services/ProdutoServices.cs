using Microsoft.EntityFrameworkCore;
using tarefa_ronan_1.Infrastructure;

namespace tarefa_ronan_1.Services
{
    public class ProdutoServices(AppDbContext context)
    {

        public async Task<List<Produto.Produto>> Listar()
        {
            return await context.Produtos.ToListAsync();
        }

        public async Task<Produto.Produto> Criar(Produto.Produto produto)
        {
            context.Produtos.Add(produto);

            await context.SaveChangesAsync();

            return produto;
        }

        public async Task<bool> Excluir(int id)
        {
            var produto = await context.Produtos
                .FirstOrDefaultAsync(x => x.Id == id);

            if (produto is null)
                return false;

            context.Produtos.Remove(produto);

            await context.SaveChangesAsync();

            return true;
        }
    }
}
