using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace MyDotnetApp.Controllers
{
  [ApiController] // To Serve HTTP responses
  [Route("api/[controller]")] // Access API by api/pathOfController
  public class CharacterController : ControllerBase
  {

    private readonly ICharacterService _characterService;
    // constructors injection
    public CharacterController(ICharacterService characterService)
    {
      _characterService = characterService;
    }

    [HttpGet("GetAll")]
    public async Task<ActionResult<ServiceResponse<List<GetCharacterDto>>>> Get()
    {
      return Ok(await _characterService.GetAllCharacter());
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<ServiceResponse<GetCharacterDto>>> GetSingle(int id)
    {
      return Ok(await _characterService.GetCharacterById(id));
    }

    [HttpPost]
    public async Task<ActionResult<ServiceResponse<List<AddCharacterDto>>>> AddCharacter(AddCharacterDto newCharacter)
    {
      return Ok(await _characterService.AddCharacter(newCharacter));
    }
  }
}