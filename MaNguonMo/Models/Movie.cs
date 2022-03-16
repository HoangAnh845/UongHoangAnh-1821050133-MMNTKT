using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MaNguonMo.Models
{
    [Table("Movies")]
    public class Movie
    {
        [Key]
        [Display(Name="Mã id")]
        public int Id { get; set; }
        [MinLength(3)]
        [MaxLength(30)]
        [Required (ErrorMessage = "warring!")]

        [Display(Name="Tiêu đề")]
        [StringLength(60, MinimumLength = 3)]
        public string? Title { get; set; }

        [Display(Name="Ngày phát hành")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [Display(Name="Thể loại")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [Required]
        [StringLength(30)]
        public string? Genre { get; set; }

        [Display(Name="Giá bán")]
        [Range(1, 100)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
    }
}