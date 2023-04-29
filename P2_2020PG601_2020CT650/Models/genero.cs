using System.ComponentModel.DataAnnotations;

namespace P2_2020PG601_2020CT650.Models
{
    public class genero
    {
        [Key][Display(Name = "ID")] public int generoId { get; set; }
        [Display(Name = "Género")] public string? nombreGenero { get; set; }
    }
}
