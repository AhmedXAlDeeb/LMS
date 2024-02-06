
using System.ComponentModel.DataAnnotations;


namespace SchoolManagementSystem.Models
{
    public class Class
    {
        [Key]
        public string code { get; set; }
        [StringLength(25)]
        public string name { get; set; }
        [StringLength(25)]
        public string hall { get; set; }
        public int time { get; set; }
    }
}
