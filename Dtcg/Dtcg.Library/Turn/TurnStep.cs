using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otcg.Library.Turn
{
    public interface ITurnStep {
        string Title { get; }
        string Abbreviation { get; }
        bool AutoSkip { get; }

        void Execute();
    }

    public enum TurnStep
    {
        StartStep,
        DrawStep,
        MainStep,
        BattleStep,
        EndStep,
    }
}
