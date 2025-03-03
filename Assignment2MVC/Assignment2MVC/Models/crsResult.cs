using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment2MVC.Models
{
    public class crsResult
    {
        public int Id { get; set; }
        public decimal Degree { get; set; }
        [ForeignKey("Course")]
        public int crs_id { get; set; }
        public Course Course { get; set; }
        [ForeignKey("Trainee")]
        public int trainee_id { get; set; }
        public Trainee Trainee { get; set; }
    }
}
