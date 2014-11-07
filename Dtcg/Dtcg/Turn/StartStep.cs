using Otcg.Library.Turn;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dtcg.Turn
{
    public class StartStep :ITurnStep
    {
        public string Title { get { return "Start Step"; } }
        public string Abbreviation { get { return "Start"; } }
        public bool AutoSkip { get { return true; } }

        public void Execute() { 
            
        }
    }
}
