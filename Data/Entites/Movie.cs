using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstBasic.Data.Entites
{

     // We Create to the Movie Class  for the Movies tables
    public class Movie
    {

        public int Id { get; set; }
        public string Title { get; set; }

        [Column()]
        [RegularExpression("^(Action|Comedy|Drama)$", ErrorMessage = "Genre must be either Action, Comedy, or Drama.")]
        public string Genre { get; set; }
       
        public int RelaseYear { get; set; }
    }
}
