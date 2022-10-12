
using FatihBank.DTOs;
using FatihBank.Features.FavAccountsFeatures.Commands;
using FatihBank.Features.FavAccountsFeatures.Queries;
using FatihBank.Models;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FatihBank.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FavAccountsController : ControllerBase
    {
        private readonly IMediator mediator;

        public FavAccountsController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<PaginationResponse<MSS_FAV_FavAccounts>>> GetAll([FromQuery(Name = "page")] int page, [FromQuery(Name = "pageSize")] int pageSize)
        {
            var query = new ListAllFavAccountsQuery(page, pageSize);
            var result = await mediator.Send(query);
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<MSS_FAV_FavAccounts>> Add(AddFavAccountsCommand command)
        {
            var result = await mediator.Send(command);
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, UpdateFavAccountsCommand command)
        {
            if (id != command.Id)
                return BadRequest();
            await mediator.Send(command);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await mediator.Send(new DeleteFavAccountsCommand { Id = id }));
        }
    }
}