using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoureTechAssess.Data
{
    public class Country
    {
        [Key]
        public int Id { get; set; }

        public string CountryCode { get; set; }
        public string Name { get; set; }
        public string CountryIso { get; set; }

        public virtual ICollection<CountryDetails> CountryDetails { get; set; }
    }
}
