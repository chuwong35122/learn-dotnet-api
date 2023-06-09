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
    public ActionResult<List<Character>> Get()
    {
      return Ok(_characterService.GetAllCharacter());
    }

    [HttpGet("{id}")]
    public ActionResult<Character> GetSingle(int id)
    {
      return Ok(_characterService.GetCharacterById(id));
    }

    [HttpPost]
    public ActionResult<List<Character>> AddCharacter(Character newCharacter)
    {

      return Ok(_characterService.AddCharacter(newCharacter));
    }
  }
}