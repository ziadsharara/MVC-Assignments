﻿using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment2MVC.Models
{
    public class Instructor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public decimal Salary { get; set; }
        public string Address { get; set; }
        [ForeignKey("Department")]
        public int dept_id { get; set; }
        public Department Department { get; set; }
        [ForeignKey("Course")]
        public int crs_id { get; set; }
        public Course Course { get; set; }
    }
}
