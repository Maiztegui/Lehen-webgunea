using System.ComponentModel.DataAnnotations;

namespace Lehen_webgunea.Models
{
    public class Table
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string Name { get; set; }
        public int DisplayOrder { get; set; }
    }
 }

