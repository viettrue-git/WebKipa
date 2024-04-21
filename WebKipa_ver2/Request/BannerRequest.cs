namespace WebApp.Request
{
    public class BannerRequest
    {
        // request api
        public int BannerId { set; get; }

        public string Url { set; get; }

        public bool isActive { set; get; }
    }
}
