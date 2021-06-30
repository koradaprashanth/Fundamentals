using AutoMapper;
using firstWebAPI.Data;
using firstWebAPI.DTOs.Character;
using firstWebAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace firstWebAPI.Services
{
    public class CharacterService : ICharacterService
    {
        private readonly IMapper _mapper;
        private readonly DataContext _dataContext;

        public CharacterService(IMapper mapper,DataContext dataContext)
        {
            this._mapper = mapper;
            this._dataContext = dataContext;
        }

        public async Task<ServiceResponse<List<GetCharacterDTO>>> AddCharacter(AddCharacterDTO newCharacter)
        {
            ServiceResponse<List<GetCharacterDTO>> serviceResponse = new ServiceResponse<List<GetCharacterDTO>>();
            Character character = _mapper.Map<Character>(newCharacter);
            await _dataContext.Characters.AddAsync(character);
            await _dataContext.SaveChangesAsync();
            serviceResponse.Data = (_dataContext.Characters.Select(c => _mapper.Map<GetCharacterDTO>(c))).ToList();            
            return serviceResponse;
        }

        public async Task<ServiceResponse<List<GetCharacterDTO>>> DeleteCharacter(int id)
        {
            ServiceResponse<List<GetCharacterDTO>> serviceResponse = new ServiceResponse<List<GetCharacterDTO>>();
            try
            {
                Character character =await _dataContext.Characters.FirstOrDefaultAsync(c => c.Id == id);
                _dataContext.Remove(character);
                await _dataContext.SaveChangesAsync();

              
                serviceResponse.Data = (_dataContext.Characters.Select(c => _mapper.Map<GetCharacterDTO>(c))).ToList();
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false; 
                serviceResponse.Message = ex.Message;
            }
             
            return serviceResponse;
        }

        public async Task<ServiceResponse<List<GetCharacterDTO>>> GetAllCharacters(int Id)
        {
            ServiceResponse<List<GetCharacterDTO>> serviceResponse = new ServiceResponse<List<GetCharacterDTO>>();
            List<Character> dbCharacters = await _dataContext.Characters.Where(c=>c.User.Id== Id).ToListAsync();
            serviceResponse.Data = (dbCharacters.Select(c=>_mapper.Map<GetCharacterDTO>(c))).ToList();
            return serviceResponse;
        }

        public async Task<ServiceResponse<GetCharacterDTO>> GetCharaterById(int id)
        {
            ServiceResponse<GetCharacterDTO> serviceResponse = new ServiceResponse<GetCharacterDTO>();
            Character dbcharacter = await _dataContext.Characters.FirstOrDefaultAsync(c => c.Id == id);
            serviceResponse.Data= _mapper.Map<GetCharacterDTO>(dbcharacter);
            return serviceResponse;
        }

        public async Task<ServiceResponse<GetCharacterDTO>> UpdateCharacter(UpdateCharacterDTO updateCharacter)
        {
            ServiceResponse<GetCharacterDTO> serviceResponse = new ServiceResponse<GetCharacterDTO>();
            try
            {
                Character character =await _dataContext.Characters.FirstOrDefaultAsync(c => c.Id == updateCharacter.Id);

                character.Name = updateCharacter.Name;
                character.Strength = updateCharacter.Strength;
                character.Intelligence = updateCharacter.Intelligence;
                character.HitPoints = updateCharacter.HitPoints;
                character.Defense = updateCharacter.Defense;
                character.Class = updateCharacter.Class;

                _dataContext.Characters.Update(character);
                await _dataContext.SaveChangesAsync();

                serviceResponse.Data = _mapper.Map<GetCharacterDTO>(character);
            }
            catch(Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
            }

            return serviceResponse;

        }
    }
}
