using System;
using System.Collections.Generic;

namespace UASIP.Repos
{
    interface IRoleRepos<T> : IDisposable
        where T : class
    {
        IEnumerable<T> GetRoleList();
        T GetRole(int id);
        IEnumerable<T> SearchRole(string name);
        void Update(T item);
        void Delete(int id);
        void Save(T item);
        bool Check(string name);

    }
}
