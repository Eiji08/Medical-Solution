namespace Medical_Solution.Models
{
    public class Medico
    {
        public int Id_Medico { get; set; }
        public ICollection<Persona> Nombre { get; set; }
        public int numero_colegiado { get; set; }
        public ICollection<Ocupacion> Especialidad { get; set; } 

    }
}
