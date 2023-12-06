namespace WebUserInterface.Models
{
    public class PropertyDetailsModel : PropertyListingModel
    {
        public string? Decription { get; set; }
        public List<string>? Amenities { get; set; }
        public List<DateTime>? BookedDates { get; set; }
    }
}
