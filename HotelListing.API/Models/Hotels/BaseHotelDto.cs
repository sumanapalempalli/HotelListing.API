using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;

namespace HotelListing.API.Models.Hotels
{
    public abstract class BaseHotelDto
    {
        [System.ComponentModel.DataAnnotations.Required]
        public string Name { get; set; }
        [System.ComponentModel.DataAnnotations.Required]
        public string Address { get; set; }

        public double Rating { get; set; }
        [Range(1,int.MaxValue)]
        public int CountryId { get; set; }
    }


}
