using System;
using System.ComponentModel.DataAnnotations;

namespace UASIP.General
{
    public class RoleObject
    {
        [Key]
        public int RoleID { get; set; }
        public string RoleName { get; set; }
        public string Description { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}