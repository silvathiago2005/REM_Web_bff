using MediatR;

namespace REM_BFF_V1.Application.UseCases.ResetPassword
{
    public class ResetPasswordResponse : IRequest<ResetPasswordRequest>
    {
        public int Id { get; set; }

        public string NewPassword { get; set; }
    }
}
