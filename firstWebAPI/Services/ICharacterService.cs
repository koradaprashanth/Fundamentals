using firstWebAPI.DTOs.Character;
using firstWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace firstWebAPI.Services
{
    public interface ICharacterService
    {
        Task<ServiceResponse<List<GetCharacterDTO>>> GetAllCharacters(int Id);

        Task<ServiceResponse<GetCharacterDTO>> GetCharaterById(int id);

        Task<ServiceResponse<List<GetCharacterDTO>>> AddCharacter(AddCharacterDTO newCharacter);

        Task<ServiceResponse<GetCharacterDTO>> UpdateCharacter(UpdateCharacterDTO updateCharacter);

        Task<ServiceResponse<List<GetCharacterDTO>>> DeleteCharacter(int id);
    }
}
