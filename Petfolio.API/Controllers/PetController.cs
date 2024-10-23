﻿using Microsoft.AspNetCore.Mvc;
using Petfolio.Communication.Responses;

namespace Petfolio.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class PetController : ControllerBase
{
    [HttpPost]
    [ProducesResponseType(typeof(ResponseRegisteredPetJson), StatusCodes.Status201Created)]

    public IActionResult Register([FromBody] RequestRegisteredPetJson request)
    {
        return Created();
    }
}
