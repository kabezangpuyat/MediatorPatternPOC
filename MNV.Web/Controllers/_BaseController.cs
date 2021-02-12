using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MNV.Requests;
using System;
using System.Threading.Tasks;

namespace MNV.Web.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class _BaseController : ControllerBase
    {
        protected readonly IMediator _mediator;

        public _BaseController(IMediator mediator)
        {
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
        }

        [ApiExplorerSettings(IgnoreApi = true)]
        public async Task<IActionResult> ExecuteQuery(IQuery query)
        {
            try
            {
                var result = await _mediator
                    .Send(query);

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }

        [ApiExplorerSettings(IgnoreApi = true)]
        public async Task<IActionResult> ExecuteCollectionQuery(CollectionQuery query)
        {
            try
            {
                var result = await _mediator
                    .Send(query);

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }
    }
}
