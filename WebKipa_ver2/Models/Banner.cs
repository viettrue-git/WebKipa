using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{

    public class Banner
    {
        [Key]
        public int BannerId { set; get; }

        public string Url { set; get; }

        public bool isActive { set; get; }

    }
}
