using MediatR;

namespace REM_BFF_V1.Application.UseCases.ResetPassword
{
    public class ResetPasswordRequest : IRequest<ResetPasswordResponse>
    {
        public int Id { get; set; }

        public string OldPassword { get; set; }

        public string NewPassword { get; set; }
    }
}
