using Microsoft.AspNetCore.Mvc;
using tarefa_ronan_1.Services;

namespace tarefa_ronan_1.Controllers;

[ApiController]
[Route("api/produtos")]
public class ProdutoController(ProdutoServices service) : ControllerBase
{

    [HttpGet]
    public async Task<IActionResult> Listar()
    {
        var produtos = await service.Listar();

        return Ok(produtos);
    }

    [HttpPost]
    public async Task<IActionResult> Criar([FromBody] Produto.Produto produto)
    {
        var criado = await service.Criar(produto);

        return CreatedAtAction(
            nameof(Listar),
            new { id = criado.Id },
            criado
        );
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> Excluir(int id)
    {
        var removido = await service.Excluir(id);

        if (!removido)
            return NotFound();

        return NoContent();
    }
}
