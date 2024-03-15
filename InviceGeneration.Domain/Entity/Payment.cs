using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InviceGeneration.Domain.Entity
{
    public class Payment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Amount { get; set; }
        public string CreatedAt { get; set; }
        public string ControlNumber { get; set;}
    }
}
