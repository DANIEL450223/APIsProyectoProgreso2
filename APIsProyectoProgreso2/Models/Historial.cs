namespace EstacionamientoAPI.Models
{
    public class Historial
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public int EspacioAsignado { get; set; }
        public DateTime FechaIngreso { get; set; }
        public DateTime FechaSalida { get; set; }
        public double TotalPagado { get; set; }
    }
}
