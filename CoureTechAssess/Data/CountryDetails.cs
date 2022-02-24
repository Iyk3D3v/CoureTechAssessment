using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CoureTechAssess.Data
{
    public class CountryDetails
    {
        public int Id { get; set; }

        public int CountryId { get; set; }
        public string Operator { get; set; }
        public string OperatorCode { get; set; }

        [ForeignKey("CountryId")]
        public virtual Country Country { get; set; }
    }
}
