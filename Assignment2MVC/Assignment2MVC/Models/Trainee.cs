using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment2MVC.Models
{
    public class Trainee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Address { get; set; }
        public decimal Grade { get; set; }

        [ForeignKey("Department")]
        public int dept_id { get; set; }
        public Department Department { get; set; }
    }
}
