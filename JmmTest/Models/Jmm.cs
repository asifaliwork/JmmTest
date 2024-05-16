using System.ComponentModel.DataAnnotations;

namespace JmmTest.Models
{
    public class Jmm
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public double MobileNumber { get; set; }

        public string title { get; set; }

        public string description { get; set; }

        public DateTime Gduedate { get; set; }

        public string priority { get; set; }

    }
}
