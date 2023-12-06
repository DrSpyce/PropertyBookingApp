using Domain.Entities;

namespace WebUserInterface.Models
{
    public class PropertyDetailsModel : PropertyListingModel
    {
        public string? Decription { get; set; }
        public List<Amenity>? Amenities { get; set; }
        public List<BookedDateModel>? BookedDates { get; set; }
    }
}
