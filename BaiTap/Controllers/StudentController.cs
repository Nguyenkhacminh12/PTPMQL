using BaiTap.Models;
using Microsoft.AspNetCore.Mvc;

namespace BaiTap.Controllers;

public class StudentController : Controller
{
    public IActionResult Index()
    {

        Student std = new Student();
        std.Gioi Tinh = "1";
        std.Chieu Cao = "2";
        std.can nang  = "3";
        return View(std);
    }
    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Create( Student std)
    {
        ViewBag.Message = "Gioi Tinh:" + std.GioiTinh + " Chieu Cao:" + std.ChieuCao + "can nang" + std.cannang;
        return View();
    }
}