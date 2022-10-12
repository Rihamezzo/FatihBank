
using FatihBank.DTOs;
using FatihBank.Features.DiscountsFeatures.Commands;
using FatihBank.Features.DiscountsFeatures.Queries;
using FatihBank.Models;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FatihBank.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiscountsController : ControllerBase
    {
        private readonly IMediator mediator;

        public DiscountsController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<PaginationResponse<MSS_ATT_Discounts>>> GetAll([FromQuery(Name = "page")] int page, [FromQuery(Name = "pageSize")] int pageSize)
        {
            var query = new ListAllDiscountsQuery(page, pageSize);
            var result = await mediator.Send(query);
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<MSS_ATT_Discounts>> Add(AddDiscountsCommand command)
        {
            var result = await mediator.Send(command);
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, UpdateDiscountsCommand command)
        {
            if (id != command.Id)
                return BadRequest();
            await mediator.Send(command);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await mediator.Send(new DeleteDiscountsCommand { Id = id }));
        }
    }
}