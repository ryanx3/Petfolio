using Petfolio.Communication.Responses;

namespace Petfolio.Application.UseCase.Pets.GetById;
public class GetPetByIdUseCase
{
    public ResponsePetJson Execute(int id)
    {
        return new ResponsePetJson {
            Id = id,
            Name = "Amora",
            Type = Communication.Enums.PetType.Cat,
            Birthday = new DateTime(year: 2024, month: 01, day: 01)
        };
    }
}
