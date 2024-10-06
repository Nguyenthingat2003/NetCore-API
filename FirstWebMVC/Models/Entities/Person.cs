using System.ComponentModel.DataAnnotations;

namespace FirstWebMVC.Models.Entities
{
    public class Person
    {
        [Key]
         
         public string PersonID { get; set;}

         public string Fullname  { get; set;}

         public string Address  { get; set;}

    }
}