﻿using Spotify.Domain.Conta.Agreggates;
using Spotify.Domain.Streaming.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify.Domain.Streaming.Agreggates
{
    public class Musica
    {
        public Guid Id { get; set; }
        public String Nome { get; set; }
        public Duracao Duracao { get; set; }

        public virtual IList<Playlist> Playlists { get; set; } = new List<Playlist>();

    }
}
