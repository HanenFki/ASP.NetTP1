using System.ComponentModel.DataAnnotations;
namespace tp1_2.Models
{
    public class Employe
    {
        public int Id { get; set; }
        [Required, StringLength(10, ErrorMessage = "Taille max 10 characters")]
        public string Name { get; set; }
        [Required]
        public string Departement { get; set; }
        [Range(200, 5000)]
        public int Salary { get; set; }
    }
}

