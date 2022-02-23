using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MaNguonMo.Models{
    [Table("Persons")]
    public class Person{
        [Key]
        public string PersonID {get; set; }
        [Required]
        public string PersonName {get; set; }

    }
}