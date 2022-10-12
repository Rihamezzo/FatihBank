using FatihBank.DTOs;
using FatihBank.Features.PricesFeatures.Commands;
using FatihBank.Features.PricesFeatures.Queries;
using FatihBank.Models;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FatihBank.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PricesController : ControllerBase
    {
        private readonly IMediator mediator;

        public PricesController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<PaginationResponse<MSS_DEF_Prices>>> GetAll([FromQuery(Name = "page")] int page, [FromQuery(Name = "pageSize")] int pageSize)
        {
            var query = new ListAllPricesQuery(page, pageSize);
            var result = await mediator.Send(query);
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<MSS_DEF_Prices>> Add(AddPricesCommand command)
        {
            var result = await mediator.Send(command);
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, UpdatePricesCommand command)
        {
            if (id != command.Id)
                return BadRequest();
            await mediator.Send(command);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await mediator.Send(new DeletePricesCommand { Id = id }));
        }
    }
}