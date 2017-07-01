using Cashbox.Models.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cashbox.Models
{
    public class Product : ModelBase, IModelHasName
    {
        [MaxLength(10)]
        public string Code { get; set; }
        [MaxLength(256)]
        public string Name { get; set; }
        public decimal Price { get; set; }
        public virtual HashSet<StoredProduct> StoreRecords { get; set; }
    }
}
