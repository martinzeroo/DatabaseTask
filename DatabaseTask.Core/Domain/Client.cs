using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Client
    {
        [Key]
        public Guid ClientId { get; set; }
        public string Gender { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
