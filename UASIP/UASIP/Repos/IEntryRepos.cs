using System;
using System.Collections.Generic;

namespace UASIP.Repos
{
    interface IEntryRepos<T> : IDisposable
        where T : class
    {
        IEnumerable<T> GetEntryList();
        void Save(T item);

    }
}
