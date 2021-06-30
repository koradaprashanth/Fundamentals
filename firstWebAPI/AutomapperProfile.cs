using AutoMapper;
using firstWebAPI.DTOs.Character;
using firstWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace firstWebAPI
{
    public class AutomapperProfile :Profile
    {
        public AutomapperProfile()
        {
            CreateMap<Character, GetCharacterDTO>();
            CreateMap<AddCharacterDTO, Character>();
        }
    }
}
