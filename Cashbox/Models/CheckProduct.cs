using Cashbox.Models.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cashbox.Models
{
    public class CheckProduct: ModelBase
    {
        public virtual Product Product { get; set; }
        public virtual Check Check { get; set; }
        public int Count { get; set; }

        [NotMapped]
        public decimal Cost { get { return Product.Price * Count; } }
    }
}
