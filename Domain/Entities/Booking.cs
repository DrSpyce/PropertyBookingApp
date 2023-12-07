using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Booking
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string? BillingAddress { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal CostPerNight { get; set; }
        [Required]
        public DateTime Start { get; set; }
        [Required]
        public DateTime End { get; set; }
        [Required]
        public Property? Property { get; set; }
        [Required]
        public string? UserId { get; set; }
    }
}
