using System.ComponentModel.DataAnnotations;

namespace P2_2020PG601_2020CT650.Models
{
    public class casos_reportados
    {
        [Key][Display(Name = "ID")] public int casoId { get; set; }
        [Display(Name = "ID de departamento")] public int departamentoId { get; set; }
        [Display(Name = "ID de género")] public int generoId { get; set; }
        [Display(Name = "Confirmados")] public int confirmados { get; set; }
        [Display(Name = "Recuperados")] public int recuperados { get; set; }
        [Display(Name = "Fallecidos")] public int fallecidos { get; set; }


    }
}
