namespace Medical_Solution.Models
{
    public class Empleado
    {
        public int id_Empleado { get; set; }
        public ICollection<Persona> Nombre { get; set; }
        public ICollection<Ocupacion> Empleo { get; set; }
    }
}
