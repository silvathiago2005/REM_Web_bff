using MediatR;

namespace REM_BFF_V1.Application.UseCases.Login
{
    public class LoginRequest: IRequest<LoginResponse>
    {
        public string Username { get; set; }

        public string Password { get; set; }
    }
}
