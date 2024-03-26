using AutoMapper;
using Spotify.Application.Conta.Dto;
using Spotify.Application.Streaming.Dto;
using Spotify.Repository.Repository;

namespace Spotify.Application.Conta
{
    public class CartaoService
    {
        private CartaoRepository CartaoRepository { get; set; }
        private IMapper Mapper { get; set; }

        public CartaoService(CartaoRepository cartaoRepository, IMapper mapper)
        {
            CartaoRepository = cartaoRepository;
            Mapper = mapper;
        }

        public IEnumerable<CartaoDto> Obter()
        {
            var cartao = CartaoRepository.GetAll();
            return Mapper.Map<IEnumerable<CartaoDto>>(cartao);
        }
    }
}
