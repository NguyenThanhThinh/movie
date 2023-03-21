using movie.data.Constants;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace movie.data.Entities
{
    public class MovieActor
    {
        [ForeignKey(nameof(Movie))]
        public int MovieId { get; set; }

        public virtual Movie Movie { get; set; } = null!;


        [ForeignKey(nameof(Actor))]
        public int ActorId { get; set; }

        public virtual Actor Actor { get; set; } = null!;

        [Required]
        [MaxLength(ValidationConstants.MaxActorCharacterName)]
        public string CharacterName { get; set; } = null!;
    }
}
