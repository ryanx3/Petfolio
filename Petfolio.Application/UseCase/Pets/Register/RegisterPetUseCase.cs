using Petfolio.Communication.Responses;

namespace Petfolio.Application.UseCase.Pet.Register;
public class RegisterPetUseCase
{
    public ResponseRegisteredPetJson Execute(RequestPetJson request)
    {
        return new ResponseRegisteredPetJson{ Id = 1, Name = "Amora"};
    }

}
