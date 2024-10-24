using Microsoft.AspNetCore.Mvc;
using Petfolio.Application.UseCase.Pet.Register;
using Petfolio.Application.UseCase.Pets.GetAll;
using Petfolio.Application.UseCase.Pets.GetById;
using Petfolio.Application.UseCase.Pets.Update;
using Petfolio.Communication.Responses;

namespace Petfolio.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class PetController : ControllerBase
{
    [HttpPost]
    [ProducesResponseType(typeof(ResponseRegisteredPetJson), StatusCodes.Status201Created)]
    [ProducesResponseType(typeof(ResponseErrorJson), StatusCodes.Status400BadRequest)]
    public IActionResult Register([FromBody] RequestPetJson request)
    {
        var response = new RegisterPetUseCase().Execute(request);
        return Created(string.Empty, response);
    }

    [HttpPut]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ResponseErrorJson), StatusCodes.Status400BadRequest)]
    public IActionResult Update([FromRoute] int id, [FromBody] RequestPetJson request)
    {
        new UpdatePetUseCase().Execute(id, request);
        return NoContent();
    }


    [HttpGet]
    [ProducesResponseType(typeof(ResponseAllPetsJson), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult GetAll() {
        var response = new GetAllPetsUseCase().Execute();

        if (response.Pets.Count != 0)
        {
            return Ok(response);
        }

        return NoContent();
    }

    [HttpGet]
    [Route("{id}")]
    [ProducesResponseType(typeof(ResponsePetJson), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ResponseErrorJson), StatusCodes.Status404NotFound)]
    public IActionResult GetById([FromRoute] int id)
    {
            var response = new GetPetByIdUseCase().Execute(id);
            return Ok(response);
    }
}
