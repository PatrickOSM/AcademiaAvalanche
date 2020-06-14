using System.ComponentModel.DataAnnotations;

namespace AcademiaAvalanche.Data
{
    public class TrainerInfo
    {
        [Key]
        public int TrainerId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Cpf { get; set; }
        [Required]
        public string Rg { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Email { get; set; }
    }
}
