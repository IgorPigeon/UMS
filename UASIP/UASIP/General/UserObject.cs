using System;
using System.ComponentModel.DataAnnotations;

namespace UASIP.General
{
    public class UserObject
    {
        [Key]
        public string UserName { get; set; }
        public string UserPass { get; set; }
        public int RoleID { get; set; }
        public bool IsActive { get; set; }
        public string Description { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime DateBirth { get; set; }
    }
}