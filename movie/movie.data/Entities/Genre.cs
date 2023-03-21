using movie.data.Constants;
using System.ComponentModel.DataAnnotations;

namespace movie.data.Entities;

public class Genre : BaseEntity
{
    [Required]
    [MaxLength(ValidationConstants.MaxGenreType)]
    public string Type { get; set; } = null!;

    public virtual ICollection<MovieGenre> Movies { get; set; }
}