using System.ComponentModel.DataAnnotations;

namespace DemoSlide4.Models
{
    public class Employess
    {
        [Key]
        public int Id { get; set; }
        public string NameEmp { get; set; }
        public string Bithdate {  get; set; }
        public string SDT {  get; set; }
    }
}
