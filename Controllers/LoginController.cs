using MediatR;
using Microsoft.AspNetCore.Http.Features;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using REM_BFF_V1.Application.UseCases.Login;
using REM_BFF_V1.Application.UseCases.ResetPassword;

namespace REM_BFF_V1.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]/[action]")]
    public class LoginController : ControllerBase
    {
        protected readonly IMediator _mediator;

        public LoginController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost(Name = "Login")]
        public async Task<IActionResult> Login(LoginRequest request)
        {
            var response = await _mediator.Send(request);

            return Ok(response);
        }
    }
}