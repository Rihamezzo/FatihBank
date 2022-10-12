using FatihBank.DTOs;
using FatihBank.Features.VacationsTypesFeatures.Commands;
using FatihBank.Features.VacationsTypesFeatures.Queries;
using FatihBank.Models;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FatihBank.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VacationsTypesController : ControllerBase
    {
        private readonly IMediator mediator;

        public VacationsTypesController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet] 
        public async Task<ActionResult<PaginationResponse<MSS_ATT_VacationsTypes>>> GetAll([FromQuery(Name = "page")] int page, [FromQuery(Name = "pageSize")] int pageSize)
        {
            var query = new ListAllVacationsTypesQuery(page, pageSize);
            var result = await mediator.Send(query);
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<MSS_ATT_VacationsTypes>> Add(AddVacationsTypesCommand command)
        {
            var result = await mediator.Send(command);
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, UpdateVacationsTypesCommand command)
        {
            if (id != command.Id)
                return BadRequest();
            await mediator.Send(command);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await mediator.Send(new DeleteVacationsTypesCommand { Id = id }));
        }
    }
}