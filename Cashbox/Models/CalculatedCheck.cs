using Cashbox.Models.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cashbox.Models
{
    public class Check : ModelBase, IModelHasDateCreate
    {
        public DateTime DateCreate { get; set; }
        public virtual HashSet<CheckProduct>  CheckProducts { get; set; }

        [NotMapped]
        public decimal TotalCost { get { return CheckProducts.Sum(it => it.Cost); } }
    }
}
