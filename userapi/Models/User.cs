using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;


namespace userapi.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Password { internal get; set; }
        protected DateTime? SignupDate { get; private set; } = DateTime.Now;
        public virtual List<Blog>? Blogs { get; set; }
    }
}
