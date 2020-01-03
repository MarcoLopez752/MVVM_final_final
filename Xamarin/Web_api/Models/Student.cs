using System.ComponentModel.DataAnnotations;

namespace Web_api.Models
{
    public class Student
    {
        [Key]
        public int studentID { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Apellido { get; set; }
        [Required]
        [Range(0,100)]
        public int nota { get; set; }

    }
}