using System.Data.Entity;
using UASIP.General;

namespace UASIP.Repos
{
    class RoleContext : DbContext
    {
        public RoleContext() : base("ums") {  }

        public DbSet<RoleObject> RoleObjects { get; set; }
    }
}
