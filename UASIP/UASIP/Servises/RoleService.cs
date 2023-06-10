using System;
using System.Collections.Generic;
using UASIP.General;
using UASIP.Repos;

namespace UASIP.Servises
{
    class RoleService
    {
        private readonly RoleRepos roleRepos = new RoleRepos();

        public IEnumerable<RoleObject> UpdateData()
        {
            IEnumerable<RoleObject> roleList = roleRepos.GetRoleList();

            return roleList;
        }

        public IEnumerable<RoleObject> SearchRole(string roleName)
        {
            IEnumerable<RoleObject> roleList = roleRepos.SearchRole(roleName);

            return roleList;
        }

        public RoleObject LoadRole(int roleID)
        {
            RoleObject roleObject = roleRepos.GetRole(roleID);

            return roleObject;
        }

        public string SaveRole(int oldRoleID, bool isUpdated, int roleID, string roleName, string description)
        {
            string messageBox = "Such role is already exist!";

            RoleObject roleObject = new RoleObject();
            roleObject.RoleName = roleName;
            roleObject.RoleID = roleID;
            roleObject.Description = description;
            roleObject.CreatedDate = DateTime.Now;
            roleObject.CreatedBy = "Admin";

            bool isExist = roleRepos.Check(roleName);
            if ((!isExist) || (oldRoleID == roleID))
            {
                if (!isUpdated)
                {
                    roleRepos.Save(roleObject);
                    messageBox = "Role saved.";
                }
                else
                {
                    roleRepos.Update(roleObject);
                    messageBox = "Role updated.";
                }
            }

            return messageBox;
        }

        public string DeleteRole(int roleID)
        {
            roleRepos.Delete(roleID);
            string messageBox = "Role deleted.";

            return messageBox;
        }
    }
}