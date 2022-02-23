using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class Student
    {
        [Key]
        public int StudentID { get; set; }
        [Required]
        public string StudentName { get; set; }

        [DataType(DataType.Date)]
        public DateTime birthday { get; set; }
        public string address { get; set; }
    }
}