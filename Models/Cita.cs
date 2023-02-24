namespace Medical_Solution.Models
{
    public class Cita
    {
        public int Id_Cita { get; set; }
        public ICollection<Pacientes> Paciente { get; set; }
        public ICollection<Medicos> Medico { get; set; }
        public DateTime Fecha { get; set; }
        public string Proposito { get; set; }
    }
}
