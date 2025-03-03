using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment2MVC.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Degree { get; set; }
        public decimal minDegree { get; set; }

        [ForeignKey("Department")]
        public int dept_id { get; set; }
        public Department Department { get; set; }
    }
}
