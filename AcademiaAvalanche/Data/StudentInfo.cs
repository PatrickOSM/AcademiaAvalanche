using System;
using System.ComponentModel.DataAnnotations;

namespace AcademiaAvalanche.Data
{
    public class StudentInfo
    {
        [Key]
        public int StudentId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Cpf { get; set; }
        [Required]
        public string Rg { get; set; }
        [Required]
        public DateTime Date_Init_Cont { get; set; }
        [Required]
        public DateTime Date_End_Cont { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Status { get; set; }
    }
}
