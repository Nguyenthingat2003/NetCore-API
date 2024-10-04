using System.ComponetModel.DataAnnotations; 
using System.ComponetModel. DataAnnotations. Schema;
namespace DemoMVC.Models.Entities
{ 
    [Table ("Student")]

    public class Student
    {
        [Key]
        
        public string StudentID  { get; set; }
        public string Fullname  { get; set; }
        public string Address  { get; set; }

    }
}