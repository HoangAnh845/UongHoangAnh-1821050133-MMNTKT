using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MaNguonMo.Models{
    [Table("Customers")]
    public class Customer:Person {

        [Display(Name="Email")]
        public string? Email {get; set;}
        [MaxLength(30)]

        [Display(Name="Giới tính")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [Required]
        [StringLength(30)]
        public string? Gender {get; set; }

        [Display(Name="Sinh nhật")]
        [DataType(DataType.Date)]
        public DateTime Birthday {get; set; }
    }
}
// dotnet-aspnet-codegenerator controller -name CustomerController -m Customer -dc ApplicationDbContext --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries -sqlite
