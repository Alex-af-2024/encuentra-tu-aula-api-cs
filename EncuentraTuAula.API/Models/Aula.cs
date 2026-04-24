namespace EncuentraTuAula.API.Models
{
    public class Aula
    {
        public int Id { get; set; }
        public string Codigo { get; set; } = string.Empty; // Ej: A-00-P01-A
        public string CodigoAnterior { get; set; } = string.Empty; // Ej: Auditorio
        public string CodigoNormalizado { get; set; } = string.Empty;
        public string Guia { get; set; } = string.Empty;
        public int Piso { get; set; }

        // Llave foránea hacia Edificio
        public int EdificioId { get; set; }
        public Edificio? Edificio { get; set; }
    }
}
