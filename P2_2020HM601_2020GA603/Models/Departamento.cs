using System.ComponentModel.DataAnnotations;

namespace P2_2020HM601_2020GA603.Models
{

    public class Departamento
    {
        [Key]
        [Display(Name = "ID")]
        public int id_departamento { get; set; }

        [Required]
        [Display(Name = "Nombre")]
        public string nombre { get; set; }

        [Display(Name = "Estado")]
        [StringLength(1)]

        public string estado { get; set; }
    }
}
