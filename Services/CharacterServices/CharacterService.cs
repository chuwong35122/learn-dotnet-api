using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyDotnetApp.Services.CharacterServices
{
  public class CharacterService : ICharacterService
  {
    private readonly IMapper _mapper;

    public CharacterService(IMapper mapper)
    {
      _mapper = mapper;
    }

    private static List<Character> characters = new List<Character> {
        new Character(),
        new Character { Id=1, Name = "Sam"}
    };

    public async Task<ServiceResponse<List<GetCharacterDto>>> AddCharacter(AddCharacterDto newCharacter)
    {
      var serviceResponse = new ServiceResponse<List<GetCharacterDto>>(); // The service response gives response status and mesasge
      characters.Add(_mapper.Map<Character>(newCharacter));
      serviceResponse.Data = characters.Select(c => _mapper.Map<GetCharacterDto>(c)).ToList();
      return serviceResponse;
    }

    public async Task<ServiceResponse<List<GetCharacterDto>>> GetAllCharacter()
    {
      var serviceResponse = new ServiceResponse<List<GetCharacterDto>>();
      serviceResponse.Data = characters.Select(c => _mapper.Map<GetCharacterDto>(c)).ToList();
      return serviceResponse;
    }

    public async Task<ServiceResponse<GetCharacterDto>> GetCharacterById(int id)
    {
      var serviceResponse = new ServiceResponse<GetCharacterDto>();
      var character = characters.FirstOrDefault(c => c.Id == id);
      serviceResponse.Data = _mapper.Map<GetCharacterDto>(character);
      return serviceResponse;
    }

    public Task<ServiceResponse<List<AddCharacterDto>>> AddCharacter(Character newCharacter)
    {
      throw new NotImplementedException();
    }

    Task<ServiceResponse<List<AddCharacterDto>>> ICharacterService.AddCharacter(AddCharacterDto newCharacter)
    {
      throw new NotImplementedException();
    }
  }
}