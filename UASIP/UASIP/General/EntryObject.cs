using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
