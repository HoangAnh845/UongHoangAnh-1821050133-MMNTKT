using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MaNguonMo.Models{
    [Table("Employees")]
    public class Employee{
        [Key]
        [Display(Name="Mã id")]
        public string? EmployeeID {get; set; }
        [Required]

        [Display(Name="Tên")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [StringLength(30)]
        public string? EmployeeName {get; set; }
        [MaxLength(30)]

        [Display(Name="Địa Chỉ")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [StringLength(30)]
        public string? Address {get; set;}

    }
}