using System;
using System.Collections.Generic;

namespace CryptoWatcher2.Models
{
    public interface IPieRepository
    {
        IEnumerable<Pie> Pies { get; }

        IEnumerable<Pie> PiesOfTheWeek {get;}

        Pie GetPieById(int pieId);
    }
}
