using FatihBank.DTOs;
using FatihBank.Features.AccountsFeatures.Commands;
using FatihBank.Features.MSS_DEF_AccountsFeatures.Queries;
using FatihBank.Models;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using FatihBank.Repositories;
using System.Diagnostics;

namespace FatihBank.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        private readonly IMediator mediator;

        public AccountsController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        
        public async Task<ActionResult<PaginationResponse<MSS_DEF_Accounts>>> GetAll([FromQuery(Name ="page")] int page, [FromQuery(Name = "pageSize")] int pageSize)
        {
            Debug.WriteLine("My debug string here");
            var query = new ListAllAccountsQuery(page, pageSize);
            var result = await mediator.Send(query);
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<MSS_DEF_Accounts>> Add(AddAccountsCommand command)
        {
            var result = await mediator.Send(command);
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody]UpdateAccountsCommand command)
        {

            if (id != command.Id)
                return BadRequest();
            await mediator.Send(command);
           // Debug.WriteLine("******************************");
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await mediator.Send(new DeleteAccountsCommand { Id = id }));
        }
    }
}
