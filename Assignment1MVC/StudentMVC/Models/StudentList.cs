using System.Collections.Generic;

namespace StudentMVC.Models
{
    public class StudentList
    {
        List<Student> studentList = new List<Student>();

        public StudentList()
        {
            studentList.Add(new Student() { Id = 1, Name = "Ziad", Address = "12 Pine St – Boston, MA, USA", Image = "1.jpg"});
            studentList.Add(new Student() { Id = 2, Name = "Sama", Address = "8 King Rd – London, UK\n", Image = "2.jpg"});
            studentList.Add(new Student() { Id = 3, Name = "Boda", Address = "5 Rue Bleu – Paris, France\n", Image = "3.jpg"});
            studentList.Add(new Student() { Id = 4, Name = "Rana", Address = "3 Maple Ln – Toronto, Canada\n", Image = "4.jpg"});
        }

        public List<Student> GetAll()
        {
            return studentList;
        }

        public Student GetById(int id)
        {
            return studentList.Find(x => x.Id == id);
        }
    }
}