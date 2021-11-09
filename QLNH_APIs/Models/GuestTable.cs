using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QLNH_APIs.Models
{
    public class GusetTable
    {
        [Key]
        public int GusetId { get; set; }
        public string GusetName { get; set; }
        public string Description { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime UpdateTime { get; set; }
        public Boolean Deleted { get; set; }
        public virtual Status Status { get; set; }
        public virtual Guset Guset { get; set; }

    }
}
