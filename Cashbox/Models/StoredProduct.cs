using Cashbox.Models.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cashbox.Models
{
    public class StoredProduct : ModelBase
    {
        public virtual Product Product { get; set; }
        public int Count { get; set; }

        [NotMapped]
        public string Name { get { return Product.Name; } }
    }
}
