using Spotify.Domain.Conta.Agreggates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify.Repository.Repository
{
    public class UsuarioRepository : RepositoryBase<Usuario>
    {
        public SpotifyContext Context { get; set; }

        public UsuarioRepository(SpotifyContext context) : base(context)
        {
            Context = context;
        }

    }
}
