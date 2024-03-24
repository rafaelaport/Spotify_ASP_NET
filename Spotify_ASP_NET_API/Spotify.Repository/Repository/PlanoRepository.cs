using Spotify.Domain.Streaming.Agreggates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify.Repository.Repository
{
    public class PlanoRepository : RepositoryBase<Plano>
    {
        public SpotifyContext Context { get; set; }

        public PlanoRepository(SpotifyContext context) : base(context)
        {
            Context = context;
        }
    }
}
