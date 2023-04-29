using System.ComponentModel.DataAnnotations;

namespace P2_2020PG601_2020CT650.Models
{
    public class departamento
    {
        [Key][Display(Name = "ID")] public int departamentoId { get; set; }
        [Display(Name = "Departamento")] public string? nombreDepartamento { get; set; }
    }
}
