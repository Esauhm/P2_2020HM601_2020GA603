using System.ComponentModel.DataAnnotations;

namespace P2_2020HM601_2020GA603.Models
{
    public class CasoReportado
    {
        [Key]
        public int id_caso { get; set; }
        public int confirmados { get; set; }
        public int recuperados { get; set; }
        public int fallecidos { get; set; }
    }
}
