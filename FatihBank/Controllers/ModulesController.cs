
using FatihBank.DTOs;
using FatihBank.Features.ModulesFeatures.Commands;
using FatihBank.Features.ModulesFeatures.Queries;
using FatihBank.Models;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FatihBank.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ModulesController : ControllerBase
    {
        private readonly IMediator mediator;

        public ModulesController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<PaginationResponse<MSS_DEF_Modules>>> GetAll([FromQuery(Name = "page")] int page, [FromQuery(Name = "pageSize")] int pageSize)
        {
            var query = new ListAllModulesQuery(page, pageSize);
            var result = await mediator.Send(query);
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<MSS_DEF_Modules>> Add(AddModulesCommand command)
        {
            var result = await mediator.Send(command);
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, UpdateModulesCommand command)
        {
            if (id != command.Id)
                return BadRequest();
            await mediator.Send(command);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await mediator.Send(new DeleteModulesCommand { Id = id }));
        }
    }
}
