using System.ComponentModel.DataAnnotations;

namespace P2_2020HM601_2020GA603.Models
{
   
        public class Generos
        {
            [Key]
            [Display(Name = "ID")]
            public int id_genero { get; set; }

            [Required]
            [Display(Name = "Genero")]
            public string genero { get; set; }

            [Display(Name = "Estado")]
            public string estado { get; set; }
        }
    
}
