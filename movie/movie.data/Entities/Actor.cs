using movie.data.Constants;
using System.ComponentModel.DataAnnotations;

namespace movie.data.Entities
{
    public class Actor : BaseEntity
    {
        [MaxLength(ValidationConstants.MaxActorName)]
        [Required]
        public string Name { get; set; }

        public virtual ICollection<MovieActor> Movies { get; set; }
    }
}
