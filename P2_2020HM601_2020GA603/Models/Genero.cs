using System.ComponentModel.DataAnnotations;

namespace P2_2020HM601_2020GA603.Models
{
    public class Genero
    {
        [Key]
        public int id_genero { get; set; }

        [Required]
      
        public string genero { get; set; }

        [StringLength(1)]
        public string estado { get; set; }
    }
}
