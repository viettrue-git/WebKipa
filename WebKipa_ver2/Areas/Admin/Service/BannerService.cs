using Microsoft.Extensions.Options;
using PagedList;
using WebApp.Models;
using WebApp.Request;

namespace WebApp.Areas.Admin.Service
{
    public class BannerService
    {

        private WebContext _webContext;
        
        /// <summary>
        /// get all banner paging
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public IEnumerable<Banner> GetAllBanner(int pageIndex = 1,int pageSize = 10)
        {
            var list =  _webContext.banners.ToList().ToPagedList(pageIndex, pageSize);
            return list;
        }
        public bool CreateBanner (BannerRequest banner)
        {

            banner.isActive = true;
            banner.Url = "112";
            banner.BannerId = 1;
            var newBanner = new Banner()
            {
                BannerId = banner.BannerId,
                Url = banner.Url,
                isActive = true
            };
            _webContext.banners.AddAsync(newBanner);
            return true;

        }
 
    }
}
