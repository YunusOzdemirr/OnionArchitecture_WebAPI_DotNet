using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using ProductApp.Application.Dto;
using ProductApp.Application.Features.Commands.CreateProduct;
using ProductApp.Application.Features.Queries.GetAllProducts;
using ProductApp.Application.Features.Queries.GetProductById;
using ProductApp.Application.Interfaces.Repository;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProdcutApp.API.Controllers
{
    [Route("api/[controller]")]
    public class ProductController : Controller
    {
        IMediator Mediator;

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
        public async Task<IActionResult> GetById(GetProductByIdQuery query)
        {
            return Ok(await Mediator.Send(query));
        }

    }
}

