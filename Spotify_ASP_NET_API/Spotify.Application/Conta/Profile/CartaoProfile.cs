using Spotify.Application.Conta.Dto;
using Spotify.Application.Streaming.Dto;
using Spotify.Domain.Streaming.Agreggates;
using Spotify.Domain.Transacao.Agreggates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify.Application.Conta.Profile
{
    internal class CartaoProfile : AutoMapper.Profile
    {
        public CartaoProfile()
        {
            CreateMap<CartaoDto, Cartao>();
            CreateMap<Cartao, CartaoDto>();
        }
    }
}
