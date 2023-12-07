using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class BookedDate
    {
        public int Id { get; set; }
        public int PropertyId { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
    }
}
