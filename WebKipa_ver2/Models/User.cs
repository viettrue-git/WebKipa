using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
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
