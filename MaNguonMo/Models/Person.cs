using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MaNguonMo.Models
{
    [Table("Persons")]
    public class Person
    {
        [Key]

        [Display(Name = "Mã id")]
        public string PersonID { get; set; }
        [Required]

        [Display(Name = "Họ và Tên")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [StringLength(30)]
        public string PersonName { get; set; }
        [MaxLength(30)]


        [Display(Name = "Địa Chỉ")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [StringLength(30)]
        public string Address { get; set; }

    }
}