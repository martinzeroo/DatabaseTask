using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    internal class EmplolyeeSales
    {
        [Key]

        public Guid SalesId { get; set; }
        public string SoldAmount { get; set; }
        public string ProductName { get; set; }
    }
}
