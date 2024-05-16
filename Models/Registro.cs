using System;

namespace Desafio.Models
{
    public class Registro
    {
        public int Id { get; set; }
        public int IdEmpleado { get; set; }
        public string Nombre { get; set; } 
        public string Apellido { get; set; }  
        public DateTime Date { get; set; }
        public string RegisterType { get; set; } 
        public string BusinessLocation { get; set; } 
        public string Genero { get; set; } 
    }
}
