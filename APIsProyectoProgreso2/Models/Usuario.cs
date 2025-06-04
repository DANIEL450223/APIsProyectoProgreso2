namespace EstacionamientoAPI.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Vehiculo { get; set; }
        public DateTime FechaIngreso { get; set; }
        public DateTime FechaSalida { get; set; }

        public double TotalPagar => Math.Ceiling((FechaSalida - FechaIngreso).TotalHours) * 2;
    }
}
