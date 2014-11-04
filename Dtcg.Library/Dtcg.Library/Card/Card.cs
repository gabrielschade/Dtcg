using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dtcg.Library.Card
{
    public abstract class Card
    {
        public CardType CardType { get; set; }
        public string Nome { get; set; }
    }
}
