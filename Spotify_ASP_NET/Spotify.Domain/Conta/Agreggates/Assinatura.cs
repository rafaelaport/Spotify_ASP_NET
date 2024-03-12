﻿using Spotify.Domain.Streaming.Agreggates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify.Domain.Conta.Agreggates
{
    public class Assinatura
    {
        public Guid Id { get; set; }
        public virtual Plano Plano { get; set; }
        public Boolean Ativo { get; set; }
        public DateTime DtAtivacao { get; set; }
    }
}
