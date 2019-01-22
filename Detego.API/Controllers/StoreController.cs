using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Detego.API.App.Stores.Queries.GetStoreList;
using Detego.API.Application.Stores.Commands.CreateStore;
using Detego.API.Application.Stores.Commands.DeleteStore;
using Detego.API.Application.Stores.Commands.UpdateStore;
using Detego.API.Application.Stores.Models;
using Detego.API.Entity;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Detego.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StoreController : Controller
    {
        private readonly IMediator _mediator;

        public StoreController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<IList<StoreViewModelDto>>> Get()
        {
            var stores = await _mediator.Send(new GetStoreListQuery());
            return Ok(stores);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateStoreCommand command)
        {
            var store = await _mediator.Send(command);
            return Ok(store);
        }

        [HttpPut]
        public async Task<IActionResult> Put([FromBody] UpdateStoreCommand command)
        {
            var store = await _mediator.Send(command);
            return Ok(store);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete([FromBody] DeleteStoreCommand command)
        {
            await _mediator.Send(command);
            return NoContent();
        }
    }
}