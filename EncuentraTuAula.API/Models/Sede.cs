namespace EncuentraTuAula.API.Models
{
    public class Sede
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;

        // Relación: Una sede tiene muchos edificios
        public ICollection<Edificio> Edificios { get; set; } = new List<Edificio>();

    }
}
