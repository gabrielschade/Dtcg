﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dtcg.Library.Card
{
    public class Creature :Card
    {
        public int Power { get; set; }

        public Creature()
        {
            this.CardType = CardType.Creature;
        }


    }
}
