using System;
using System.Threading.Tasks;
using Detego.API.App.Stores.Queries.GetStoreList;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Detego.API.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class StoreController : ControllerBase
    {
        private readonly IMediator _mediator;

        public StoreController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("/")]
        public async Task<IActionResult> GetStoreList()
        {
            var result = await _mediator.Send(new GetStoreListQuery());
            return new JsonResult(result);
        }
    }
}