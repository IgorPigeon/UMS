using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using UASIP.General;

namespace UASIP.Repos
{
    public class UserRepos : IUserRepos<UserObject>
    {
        private UserContext db;
        RoleRepos roleRepos = new RoleRepos();

        public UserRepos()
        {
            this.db = new UserContext();
        }

        public IEnumerable<UserObject> GetUserList()
        {
            db = new UserContext();
            return db.UserObjects;
        }

        public IEnumerable<UserObject> SearchUser(string name)
        {
            IEnumerable<UserObject> results = db.UserObjects.Where(u => u.UserName.Contains(name));

            return results;
        }
        public bool Check(string name)
        {
            bool results = db.UserObjects.Any(r => r.UserName == name);

            return results;
        }

        public UserObject GetUser(string userName)
        {
            return db.UserObjects.Find(userName);
        }

        public async void Update(UserObject userObject)
        {
            UserObject userInDb = db.UserObjects.Find(userObject.UserName);
            userInDb.UserName = userObject.UserName;
            userInDb.UserPass = userObject.UserPass;
            userInDb.IsActive = userObject.IsActive;
            userInDb.Description = userObject.Description;
            userInDb.RoleID = userObject.RoleID;
            userInDb.DateBirth = userObject.DateBirth;


            db.Entry(userInDb).State = EntityState.Modified;
            await db.SaveChangesAsync();
        }

        public async void Delete(string name)
        {
            UserObject userObject = FindUser(name);
            if (userObject != null)
            {
                db.UserObjects.Remove(userObject);
                await db.SaveChangesAsync();
            }
        }

        public async void Save(UserObject userObject)
        {
            db.UserObjects.Add(userObject);
            await db.SaveChangesAsync();
        }

        public UserObject FindUser(string userName)
        {
            return db.UserObjects.Find(userName);
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
