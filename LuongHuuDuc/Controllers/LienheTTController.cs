using Microsoft.AspNetCore.Mvc;

namespace LuongHuuDuc.Controllers
{
    public class LienheTTController : Controller
    {
        public IActionResult Thongtinhocvien()
        {
            ViewData["Hovaten"] = "Lương Hữu Đức";
            ViewData["Ngaysinh"] = "25/01/2001";
            ViewData["Email"] = "lhduc.lm2001@gmail.com";
            ViewData["Sodienthoai"] = "0563250798";
            return View();
        }
    }
}
