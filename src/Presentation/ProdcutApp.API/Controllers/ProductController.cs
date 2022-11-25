using MediatR;
using Microsoft.AspNetCore.Mvc;
using ProductApp.Application.Features.Commands.CreateProduct;
using ProductApp.Application.Features.Queries.GetAllProducts;
using ProductApp.Application.Features.Queries.GetProductById;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProdcutApp.API.Controllers;

[Route("api/[controller]")]
public class ProductController : Controller
{
    private readonly IMediator Mediator;

    public ProductController(IMediator mediator)
    {
        Mediator = mediator;
    }

    // GET: api/values
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var query = new GetAllProductQuery();
        return Ok(await Mediator.Send(query));
    }

    [HttpPost("[action]")]
    public async Task<IActionResult> Create(CreateProductCommand command)
    {
        return Ok(await Mediator.Send(command));
    }

    [HttpGet("[action]")]
    public async Task<IActionResult> GetById(int id)
    {
        var query = new GetProductByIdQuery { Id = id };
        return Ok(await Mediator.Send(query));
    }
}