using Spotify.Application.Streaming.Dto;
using Spotify.Domain.Streaming.Agreggates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify.Application.Streaming.Profile
{
    internal class PlanoProfile : AutoMapper.Profile
    {
        public PlanoProfile() 
        {
            CreateMap<PlanoDto, Plano>();
            CreateMap<Plano, PlanoDto>();
        }
    }
}
