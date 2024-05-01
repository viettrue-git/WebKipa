using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace WebApp.Models
{
    public class UserModel
    {
        [Key]
        [StringLength(20)]
        public string UserId { set; get; }

        [Required(ErrorMessage = "Vui lòng nhập tên đăng nhập")]
        [DisplayName("Tên đăng nhập")]
        [StringLength(25, ErrorMessage = "Tên đăng nhập không dài quá 25 ký tự!")]
        public string UserName { set; get; }

        [Required(ErrorMessage = "Vui lòng nhập mật khẩu")]
        [StringLength(50,ErrorMessage ="Mật khẩu không dài quá 50 ký tự")]
        public string Password { set; get; }

        [Required(ErrorMessage = "Vui lòng nhập email")]
        [StringLength(50, ErrorMessage = "Email không dài quá 50 ký tự")]
        public string Email { set; get; }
    }
}
