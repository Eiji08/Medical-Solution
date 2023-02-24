namespace Medical_Solution.Models
{
    public class Paciente
    {
        public int d_Paciente { get; set; }
        public ICollection<Persona> Nombre { get; set; }
        public ICollection<Medico> Medico { get; set; }

    }
}
