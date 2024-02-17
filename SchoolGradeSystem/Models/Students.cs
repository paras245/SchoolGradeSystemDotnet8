using System.ComponentModel.DataAnnotations;

namespace SchoolGradeSystem.Models
{
    public class Students
    {
        [Key]
        public int StudentId { get; set; }

        public required string StudentName { get; set;}

        public string NumberOfSubject { get; set;}


    }
}
