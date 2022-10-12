using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using FatihBank.Repositories;
using FatihBank.Models;
using FatihBank.DTOs;
using MediatR;
using FatihBank.Features.MSS_DEF_UsersFeatures.Commands;
using FatihBank.Features.MSS_DEF_UsersFeatures.Queries;

namespace FatihBank.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUsersRepository usersRepository;
        private readonly IMediator _mediator;

        public UsersController(IUsersRepository usersRepository, IMediator mediator)
        {
            this.usersRepository = usersRepository;
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<PaginationResponse<MSS_DEF_Users>>>GetAll([FromQuery(Name = "page")] int page, [FromQuery(Name = "pageSize")] int pageSize)
        {
            var query = new ListAllUsersQuery(page, pageSize);
            var result =await _mediator.Send(query);
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<MSS_DEF_Users>> Add(AddUsersCommand command)
        {
            var result = await _mediator.Send(command);
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id,UpdateUsersCommand command)
        {
            if (id != command.Id)
                return BadRequest();
           await _mediator.Send(command);
           return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await _mediator.Send(new DeleteUsersCommand { Id = id }));
        }

        [HttpGet("/test")]
        public async Task<string> test()
        {
            return "test";
        }
    }
}
