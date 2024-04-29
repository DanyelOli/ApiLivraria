using ApiLivraria.communication.Request;
using ApiLivraria.communication.Response;
using Microsoft.AspNetCore.Mvc;

namespace ApiLivraria.Controllers;
[Route("api/[controller]")]
[ApiController]
public class LivrosController : ControllerBase
{
    [HttpGet]
    [ProducesResponseType(typeof(List<Books>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
    public IActionResult GetAllLivros()
    {
        var response = new List<Books>
        {
            new Books { id = 1, titulo = "C#", autor = "Daniel", genero = "ficcao", preco = 10, estoque = 5},
            new Books { id = 2, titulo = "Java", autor = "Ligia", genero = "ficcao", preco = 15, estoque = 2},
            new Books { id = 3, titulo = "Javascript", autor = "Jose", genero = "ficcao", preco = 20, estoque = 7},
            new Books { id = 4, titulo = "C++", autor = "Arthur", genero = "ficcao", preco = 30, estoque = 1}
        };

        return Ok(response);
    }

    [HttpPost]
    [ProducesResponseType(typeof(RequestRegisterBookJson), StatusCodes.Status201Created)]
    public IActionResult Create([FromBody] RequestRegisterBookJson request)
    {
        var response = new ResponseRegisterBookJson
        {
            id = request.id,
            titulo = request.titulo,
            autor = request.autor,
            genero = request.genero,
            preco = request.preco,
            estoque = request.estoque
        };

        return Created(string.Empty, response);
    }

    [HttpPut]
    [Route("{id}")]
    [ProducesResponseType( StatusCodes.Status204NoContent)]
    public IActionResult Update(
        [FromRoute] int id,
        [FromBody] RequestUpdateBookJson request)
    {
        return NoContent();
    }

    [HttpDelete]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult Delete([FromRoute] int id)
    {
        return NoContent();
    }

}
