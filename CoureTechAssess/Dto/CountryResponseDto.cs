using CoureTechAssess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoureTechAssess.Dto
{
    public class CountryResponseDto
    {
        public string PhoneNum { get; set; }
        public CountryDto Country { get; set; }
        public List<CountryDetailsDto> CountryDetails { get; set; }
    }
}
