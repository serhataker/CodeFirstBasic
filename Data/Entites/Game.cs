
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstBasic.Data.Entites
{

    // We Create to the Game Class  for the game tables
    public class Game
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [Column()]
        [RegularExpression("^(Xbox|PC|PlayStation)$", ErrorMessage = "Platform must be either Xbox, PC, or PlayStation.")] // we limited the data

        public string Platform { get; set; }
        [Column()]
        [Range(0, 10, ErrorMessage = "Rating must be between 0 and 10.")] //we limited the data

        public decimal Rating { get; set; }
    }
}
