using System;
using System.Collections.Generic;
using UASIP.General;
using UASIP.Repos;

namespace UASIP.Servises
{
    class UserService
    {
        private readonly UserRepos userRepos = new UserRepos();

        public IEnumerable<UserObject> UpdateData()
        {
            IEnumerable<UserObject> userList = userRepos.GetUserList();

            return userList;
        }

        public IEnumerable<UserObject> SearchUser(string userName)
        {
            IEnumerable<UserObject> userList = userRepos.SearchUser(userName);

            return userList;
        }

        public UserObject LoadUser(string userName)
        {
            UserObject userObject = userRepos.GetUser(userName);

            return userObject;
        }

        public string SaveUser(string oldUserName, bool isUpdated, string userPass, int roleID, bool isActive, string userName, string description, DateTime dateBirth)
        {
            string messageBox = "Such user is already exist!";

            UserObject userObject = new UserObject();
            userObject.UserName = userName;
            userObject.UserPass = userPass;
            userObject.RoleID = roleID;
            userObject.IsActive = isActive;
            userObject.Description = description;
            userObject.CreatedDate = DateTime.Now;
            userObject.CreatedBy = "Admin";
            userObject.DateBirth = dateBirth;

            bool isExist = userRepos.Check(userName);
            if ((!isExist) || (oldUserName == userName))
            {
                if (!isUpdated)
                {
                    userRepos.Save(userObject);
                    messageBox = "User saved.";
                }
                else
                {
                    userRepos.Update(userObject);
                    messageBox = "User updated.";
                }
            }

            return messageBox;
        }

        public string DeleteUser(string userName)
        {
            userRepos.Delete(userName);
            string messageBox = "User deleted.";

            return messageBox;
        }

        public bool LoginCheck(string userName, string userPass)
        {
            UserObject userObject = userRepos.FindUser(userName);
            if (userObject != null)
            {
                return (userObject.UserName == userName) && (userObject.UserPass == userPass);
            }
            else
            {
                return false;
            }
        }
    }
}