using System.ComponentModel.DataAnnotations;

namespace WebKipa_ver2.Models
{
    public class User
    {
        [Key]
        [StringLength(20)]
        public string UserId { set; get; }
        public string UserName { set; get; }
        public string Password { set; get; }
        public string Email { set; get; }
    }
}
