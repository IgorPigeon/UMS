using System.Data.Entity;
using UASIP.General;

namespace UASIP.Repos
{
    class UserContext : DbContext
    {
        public UserContext() : base("ums") { }
        public DbSet<UserObject> UserObjects { get; set; }
    }
}