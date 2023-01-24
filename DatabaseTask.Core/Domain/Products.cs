using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Products
    {
        [Key]

        public Guid ProductId { get; set; }
        public int Name { get; set; }
        public string Price { get; set; }
        public string Description { get; set; }
    }
}
