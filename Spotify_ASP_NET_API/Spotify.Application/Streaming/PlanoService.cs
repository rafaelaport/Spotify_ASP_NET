using AutoMapper;
using Spotify.Application.Streaming.Dto;
using Spotify.Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify.Application.Streaming
{
    public class PlanoService
    {
        private PlanoRepository PlanoRepository { get; set; }
        private IMapper Mapper { get; set; }

        public PlanoService(PlanoRepository planoRepository, IMapper mapper)
        {
            PlanoRepository = planoRepository;
            Mapper = mapper;
        }

        public IEnumerable<PlanoDto> Obter()
        {
            var plano = this.PlanoRepository.GetAll();
            return this.Mapper.Map<IEnumerable<PlanoDto>>(plano);
        }
    }
}
