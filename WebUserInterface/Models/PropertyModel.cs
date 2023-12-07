using Domain.Entities;

namespace WebUserInterface.Models
{
    public class PropertyModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Blurb { get; set; }
        public string? Location { get; set; }
        public int NumberOfBedrooms { get; set; }
        public decimal CostPerNight { get; set; }
        public string? Decription { get; set; }
        public List<Amenity>? Amenities { get; set; }
        public List<BookingModel>? Booking { get; set; }
    }
}
