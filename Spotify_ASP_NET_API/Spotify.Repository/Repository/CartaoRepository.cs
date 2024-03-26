using Spotify.Domain.Streaming.Agreggates;
using Spotify.Domain.Transacao.Agreggates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify.Repository.Repository
{
    public class CartaoRepository : RepositoryBase<Cartao>
    {
        public SpotifyContext Context { get; set; }

        public CartaoRepository(SpotifyContext context) : base(context)
        {
            Context = context;
        }
    }
}
