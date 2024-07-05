using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Razor.Models
{
    public class Category
    {
        //Key is used to define the primary key attribute in the model when connecting with the db
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        [DisplayName("Category Name")]
        public string Name { get; set; }
        [DisplayName("Display Order")]
        [Range(1,100, ErrorMessage = "Display Order must be between 1-100")]
        public int DisplayOrder { get; set; }
    }
}
