using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Property
    {
        public int Id { get; set; }
        [Required]
        [StringLength(30)]
        public string? Name { get; set; }
        //rework
        public string? Blurb { get; set; }
        [Required]
        [StringLength(50)]
        public string? Location { get; set; }
        [Required]
        public int NumberOfBedrooms { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal CostPerNight { get; set; }
        [Required]
        [StringLength(50)]
        public string? Decription { get; set; }
        public List<Amenity>? Amenities { get; } = new();
        public List<Booking>? Booking { get; } = new();
    }
}
