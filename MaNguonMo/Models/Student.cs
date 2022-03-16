using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MaNguonMo.Models{
    [Table("Students")]
    public class Student{
        [Key]
        [Display(Name="Sinh Viên ID")]
        public string? StudentID {get; set; }
        [Required]

        [Display(Name="Họ và Tên Sinh Viên")]

        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [StringLength(30)]
        public string? StudentName {get; set; }
        [MaxLength(30)]

        [Display(Name="Địa Chỉ")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [StringLength(30)]
        public string? Address {get; set;}
    }
}