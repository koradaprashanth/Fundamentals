using firstWebAPI.DTOs.Character;
using firstWebAPI.Models;
using firstWebAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace firstWebAPI.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[Controller]")]
    public class CharacterController : ControllerBase
    {
        public readonly ICharacterService _characterService;

        public CharacterController(ICharacterService characterservice)
        {
            this._characterService = characterservice;
        }  
        
        //private static Character knight = new Character();
        //[AllowAnonymous]
        [Route("GetAll")] // or [HttpGet("GetAll")]
        public async Task<IActionResult> Get()
        {
            int id = Convert.ToInt32(User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier).Value);
            return Ok(await _characterService.GetAllCharacters(id));
        }

        //public IActionResult GetSingle()
        //{
        //    return Ok(characters[0]);
        //}

        [HttpGet("{id}")]
        public async Task<IActionResult> GetSingle(int id)
        {
            return Ok(await _characterService.GetCharaterById(id));
        }

        [HttpPost]
        public async Task<IActionResult> AddCharacter(AddCharacterDTO character)
        {
            return Ok(await _characterService.AddCharacter(character));
        }

        [HttpPut] 
        public async Task<IActionResult> UpdateCharacter(UpdateCharacterDTO character)
        {
            ServiceResponse<GetCharacterDTO> response = await _characterService.UpdateCharacter(character);
            if (response.Data == null)
            {
                return NotFound(response);
            }
            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            ServiceResponse<List<GetCharacterDTO>> response = await _characterService.DeleteCharacter(id) ;
            if (response.Data == null)
            {
                return NotFound(response);
            }
            return Ok(response);
        }
    }
}
