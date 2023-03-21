using movie.data.Constants;
using System.ComponentModel.DataAnnotations;

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
