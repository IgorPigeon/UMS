using System;
using System.Collections.Generic;

namespace UASIP.Repos
{
    interface IUserRepos<T> : IDisposable
        where T : class
    {
        IEnumerable<T> GetUserList();
        T GetUser(string name);
        IEnumerable<T> SearchUser(string name);
        void Update(T item);
        void Delete(string name);
        void Save(T item);
        bool Check(string name);

    }
}
