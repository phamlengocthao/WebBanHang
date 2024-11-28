using Microsoft.Owin;
using Owin;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Services.Description;

[assembly: OwinStartupAttribute(typeof(WebBanHangOnline.Startup))]
namespace WebBanHangOnline
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            ConfigureMvc();
        }
        public void ConfigureMvc()
        {
            // Đăng ký các route cho ứng dụng
            System.Web.Routing.RouteTable.Routes.MapMvcAttributeRoutes();  // Nếu bạn sử dụng attribute routing
            RouteConfig.RegisterRoutes(System.Web.Routing.RouteTable.Routes);  // Cấu hình route mặc định
        }
    }
}
