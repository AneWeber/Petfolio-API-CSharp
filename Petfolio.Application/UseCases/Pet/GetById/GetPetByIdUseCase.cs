using Petfolio.Communication.Responses;

namespace Petfolio.Application.UseCases.Pet.GetById;
public class GetPetByIdUseCase
{
    public ResponsePetJson Execute(int id)
    {
        return new ResponsePetJson
        {
            Id = id,
            Name = "Sample Pet",
            DateOfBirth = new DateTime(year: 2021, month: 01, day: 01),
            Type = Communication.Enums.PetType.Dog 
        };
    }
}
