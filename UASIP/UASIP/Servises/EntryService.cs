using System;
using System.Collections.Generic;
using UASIP.General;
using UASIP.Repos;

namespace UASIP.Servises
{
    class EntryService
    {
        private readonly EntryRepos entryRepos = new EntryRepos();

        public IEnumerable<EntryObject> UpdateData()
        {
            IEnumerable<EntryObject> entryList = entryRepos.GetEntryList();

            return entryList;
        }

        public void SaveEntry(string userName)
        {
            EntryObject entryObject = new EntryObject();
            entryObject.Username = userName;
            entryObject.EntryTime = DateTime.Now;

            entryRepos.Save(entryObject);
        }
    }
}