using FatihBank.DTOs;
using FatihBank.Features.MonthSalariesFeatures.Commands;
using FatihBank.Features.MonthSalariesFeatures.Queries;
using FatihBank.Models;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FatihBank.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MonthSalariesController : ControllerBase
    {
        private readonly IMediator mediator;

        public MonthSalariesController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<PaginationResponse<MSS_ATT_Month_Salaries>>> GetAll([FromQuery(Name = "page")] int page, [FromQuery(Name = "pageSize")] int pageSize)
        {
            var query = new ListAllMonthSalariesQuery(page, pageSize);
            var result = await mediator.Send(query);
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<MSS_ATT_Month_Salaries>> Add(AddMonthSalariesCommand command)
        {
            var result = await mediator.Send(command);
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, UpdateMonthSalariesCommand command)
        {
            if (id != command.Id)
                return BadRequest();
            await mediator.Send(command);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await mediator.Send(new DeleteMonthSalariesCommand { Id = id }));
        }
    }
}