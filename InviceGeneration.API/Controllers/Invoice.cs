using InviceGeneration.Application.Query;
using InviceGeneration.Domain.Entity;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace InviceGeneration.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Invoice : ControllerBase
    {
        private readonly IMediator _mediator;

        public Invoice(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var query = new GetInvoiceQuery();
                var res = await _mediator.Send(query);
                return Ok(res);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


    }
}
