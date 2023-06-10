using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using UASIP.General;

namespace UASIP.Repos
{
    public class EntryRepos : IEntryRepos<EntryObject>
    {
        private EntryContext db;

        public EntryRepos()
        {
            this.db = new EntryContext();
        }

        public IEnumerable<EntryObject> GetEntryList()
        {
            db = new EntryContext();
            return db.EntryObjects;
        }

        public async void Save(EntryObject entryObject)
        {
            db.EntryObjects.Add(entryObject);
            await db.SaveChangesAsync();
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if(!this.disposed)
            {
                if(disposing)
                {
                    db.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
