using System.ComponetModel.DataAnnotations;
namespace DemoMVC.Model.Entities
{
    public class NguyenThiNgat
    {
        [Key]
        public string NguyenThiNgatID { get; set;}

        public string NguyenThiNgatName { get; set;}
    }
}