namespace EncuentraTuAula.API.Models
{
    public class Edificio
    {
        public int Id { get; set; }
        public string Letra { get; set; } = string.Empty;

        // Llave foránea hacia Sede
        public int SedeId { get; set; }
        public Sede? Sede { get; set; }

        // Relación: Un edificio tiene muchas aulas
        public ICollection<Aula> Aulas { get; set; } = new List<Aula>();
    }
}
