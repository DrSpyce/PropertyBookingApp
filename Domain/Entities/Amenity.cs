using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    [Index(nameof(Name), IsUnique = true)]
    public class Amenity
    {
        public int Id { get; set; }
        [Required]
        [StringLength(30)]
        public string? Name { get; set; }
        public List<Property> Properties { get; } = new();
    }
}
