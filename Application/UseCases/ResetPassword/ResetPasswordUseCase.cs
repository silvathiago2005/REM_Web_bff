using MediatR;

namespace REM_BFF_V1.Application.UseCases.ResetPassword
{
    public class ResetPasswordUseCase : IRequestHandler<ResetPasswordRequest, ResetPasswordResponse>
    {
        public Task<ResetPasswordResponse> Handle(ResetPasswordRequest request, CancellationToken cancellationToken)
        {
            ResetPasswordResponse response = new ResetPasswordResponse();   

            if(request != null && request.Id == 1)
            {
                response.Id = request.Id;
                response.NewPassword = request.NewPassword;
            }

            return Task.FromResult(response);
        }
    }
}
