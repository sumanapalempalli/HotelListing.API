using HotelListing.API.Models.Hotels;

namespace HotelListing.API.Models.Country
{
    public class CountryDto : BaseCountryDto
    {
        public int CountryId { get; set; }

        public List<HotelDto> Hotels { get; set; }
    }


}
