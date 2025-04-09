using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Model
{
    [Table("employee")]
    public class Employee
    {
        [Key]
        public int id { get; set; }

        public string name { get; set; }

        public int age { get; set; }

        public string? photo { get; set; }

        public  Employee()
        {

        }

        public Employee(int id, string name, int age, string photo)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.photo = photo;
        }
    }
}
