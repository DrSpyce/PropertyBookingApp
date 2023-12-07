using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebUserInterface.Models
{
    public class BookingModel
    {
        public string? BillingAddress { get; set; }
        public decimal CostPerNight { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public string? UserId { get; set; }
        public PropertyModel PropertyModel { get; set; }
        public int PropertyId { get; set; }
    }
}
