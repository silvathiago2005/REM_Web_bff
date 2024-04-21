using MediatR;
using Microsoft.AspNetCore.Mvc;
using REM_BFF_V1.Application.UseCases.ResetPassword;

namespace REM_BFF_V1.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]/[action]")]
    public class ResetController : ControllerBase
    {
        protected readonly IMediator _mediator;

        public ResetController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost(Name = "ResetPassword")]
        public async Task<IActionResult> ResetPassword(ResetPasswordRequest passwordRequest)
        {
            var response = await _mediator.Send(passwordRequest);

            if(response == null || response.Id == 0)
            {
                return BadRequest();
            }

            return Ok(response);
        }

    }
}
