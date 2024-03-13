using Spotify.Domain.Streaming.Agreggates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify.Repository.Repository
{
    public class BandaRepository : RepositoryBase<Banda>
    {
        public BandaRepository(SpotifyContext context) : base(context)
        {
        }
    }
}
