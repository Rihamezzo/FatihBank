using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using FatihBank.Repositories;
using FatihBank.Models;
using FatihBank.DTOs;
using FatihBank.Features.MSS_DEF_CustomersFeatures.Commands;
using FatihBank.Features.MSS_DEF_CustomersFeatures.Queries;
using MediatR;


namespace FatihBank.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly IMediator mediator;

        public CustomersController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<PaginationResponse<MSS_DEF_Customers>>> GetAll([FromQuery(Name = "page")] int page, [FromQuery(Name = "pageSize")] int pageSize)
        {
            var query = new ListAllCustomersQuery(page, pageSize);
            var result = await mediator.Send(query);
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<MSS_DEF_Customers>> Add(AddCustomersCommand command)
        {
            var result = await mediator.Send(command);
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id,UpdateCustomersCommand command)
        {
            if (id != command.Id)
                return BadRequest();
            await mediator.Send(command);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await mediator.Send(new DeleteCustomersCommand { Id = id }));
        }
    }
}
