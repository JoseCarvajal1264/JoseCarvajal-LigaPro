using System.ComponentModel.DataAnnotations;

namespace JoseCarvajal_MVC2.Models
{
    public class Jugador
    {
        [Key]
        public int Id { get; set; } 
        public string Nombre { get; set; }
        public string Posicion { get; set; }
        [Range(15, 45)]
        public int Edad { get; set; }
        public Equipo Equipo { get; set; }

    }
}
