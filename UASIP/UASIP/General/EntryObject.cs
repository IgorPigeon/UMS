using System;
using System.ComponentModel.DataAnnotations;

namespace UASIP.General
{
    public class EntryObject
    {
        [Key]
        public int ID { get; set; }
        public string Username { get; set; }
        public DateTime EntryTime { get; set; }
    }
}