using System.ComponentModel.DataAnnotations;

namespace userapi.Models
{
    public class Blog
    {
        [Key]
        public int BlogId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public virtual User? User { get; set; }
    }
}
