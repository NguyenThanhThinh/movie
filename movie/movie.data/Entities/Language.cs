using movie.data.Constants;
using System.ComponentModel.DataAnnotations;

namespace movie.data.Entities
{
    public class Language : BaseEntity
    {
        public Language()
        {
            this.Movies = new HashSet<MovieLanguage>();
        }
        [Required]
        [MaxLength(ValidationConstants.MaxLanguageName)]
        public string LanguageName { get; set; } = null!;

        public virtual ICollection<MovieLanguage> Movies { get; set; }
    }
}
