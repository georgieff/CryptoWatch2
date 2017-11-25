using System;
using System.Collections.Generic;

namespace CryptoWatcher2.Models
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> Categories { get; }
    }
}
