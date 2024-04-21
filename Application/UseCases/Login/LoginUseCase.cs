using MediatR;

namespace REM_BFF_V1.Application.UseCases.Login
{
    public class LoginUseCase : IRequestHandler<LoginRequest, LoginResponse>
    {
        public Task<LoginResponse> Handle(LoginRequest request, CancellationToken cancellationToken)
        {
            LoginResponse response = new LoginResponse();

            if (request != null && request.Username == "silvathiago2005" && request.Password == "Oficin@g3")
            {
                response.Id = 1;
                response.Name = "Thiago Lopes da Silva";
                response.Token = "silvathiago2005";
                response.Profile = "Desenvolvedor";
            }

            return Task.FromResult(response);
        }
    }
}
