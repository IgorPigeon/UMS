using System.Data.Entity;
using UASIP.General;

namespace UASIP.Repos
{
    class EntryContext : DbContext
    {
        public EntryContext() : base("ums") {  }

        public DbSet<EntryObject> EntryObjects { get; set; }
    }
}
