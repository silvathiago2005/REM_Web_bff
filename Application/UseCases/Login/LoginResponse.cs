using MediatR;

namespace REM_BFF_V1.Application.UseCases.Login
{
    public class LoginResponse: IRequest<LoginRequest>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Profile { get; set; }

        public string Token { get; set; }


    }
}
