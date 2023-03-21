using movie.data.Constants;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace movie.data.Entities
{
    public class Country : BaseEntity
    {
        [Required]
        [MaxLength(ValidationConstants.MaxCountryName)]
        public string Name { get; set; } = null!;

        public virtual ICollection<MovieCountry> MovieCounties { get; set; }
    }
}
