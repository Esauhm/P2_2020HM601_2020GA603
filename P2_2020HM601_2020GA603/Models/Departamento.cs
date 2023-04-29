using System.ComponentModel.DataAnnotations;

namespace P2_2020HM601_2020GA603.Models
{

    public class Departamento
    {
        [Key]
        public int id_departamento { get; set; }

        [Required]
       
        public string nombre { get; set; }

        [StringLength(1)]
        public string estado { get; set; }
    }
}
