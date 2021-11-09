using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QLNH_APIs.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime UpdateTime { get; set; }
        public Boolean Deleted { get; set; }
        public Boolean Voided { get; set; }
        public double TotalPrice { get; set; }
        public double PaidAmount { get; set; }
        public virtual IList<OrderItem> OrderItems { get; set; }
    }
}
