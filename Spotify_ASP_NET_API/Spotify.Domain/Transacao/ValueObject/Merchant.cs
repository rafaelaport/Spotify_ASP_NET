using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify.Domain.Transacao.ValueObject
{
    public record Merchant
    {
        public string Nome { get; set; }
    }
}
