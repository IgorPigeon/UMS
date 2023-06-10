using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using UASIP.General;

namespace UASIP.Repos
{
    public class RoleRepos : IRoleRepos<RoleObject>
    {
        private RoleContext db;

        public RoleRepos()
        {
            this.db = new RoleContext();
        }

        public IEnumerable<RoleObject> GetRoleList()
        {
            db = new RoleContext();

            return db.RoleObjects;
        }

        public IEnumerable<RoleObject> SearchRole(string name)
        {
            IEnumerable<RoleObject> results = db.RoleObjects.Where(r => r.RoleName.Contains(name));

            return results;
        }
        public bool Check(string name)
        {
            bool results = db.RoleObjects.Any(r => r.RoleName == name);

            return results;
        }

        public RoleObject GetRole(int roleID)
        {
            return db.RoleObjects.Find(roleID);
        }

        public async void Update(RoleObject roleObject)
        {
            RoleObject roleInDb = db.RoleObjects.Find(roleObject.RoleID);
            roleInDb.RoleName = roleObject.RoleName;
            roleInDb.Description = roleObject.Description;

            db.Entry(roleInDb).State = EntityState.Modified;
            await db.SaveChangesAsync();
        }

        public async void Delete(int id)
        {
            RoleObject roleObject = db.RoleObjects.Find(id);
            if (roleObject != null)
            {
                db.RoleObjects.Remove(roleObject);
                await db.SaveChangesAsync();
            }
        }

        public async void Save(RoleObject roleObject)
        {
            db.RoleObjects.Add(roleObject);
            await db.SaveChangesAsync();
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
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