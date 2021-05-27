using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HotelListing.Models
{
    public class CreateCountryDTO
    {
        
        [Required]
        [StringLength(maximumLength: 150, ErrorMessage = "Country Name should be maximum 150 characters")]
        public string Name { get; set; }
        [Required]
        [StringLength(maximumLength: 2, ErrorMessage = "Country ShortName should be maximum 2 characters")]
        public string ShortName { get; set; }
    }
    public class CountryDTO : CreateCountryDTO
    {
        public int Id { get; set; }

        public  IList<hotelDTO> Hotels { get; set; }
    }
}
