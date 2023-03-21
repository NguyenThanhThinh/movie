using System.ComponentModel.DataAnnotations.Schema;

namespace movie.data.Entities
{
    public class MovieLanguage
    {
        [ForeignKey(nameof(Movie))]
        public int MovieId { get; set; }

        public Movie Movie { get; set; }

        [ForeignKey(nameof(Language))]
        public int LanguageId { get; set; }

        public Language Language { get; set; }
    }
}
