using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DEMO.Models;

namespace DEMO.Controllers;
public class StudentController : Controllers
{
    public IActionResult student()
    {
        return View();
    }
    [HttpPost]
    public IActionResult student()
    {
    string Message ="Chieu Cao" + name + "Can Nang" + name + "Gioi Tinh";
    ViewBag.Message = Message;
    return View();
    }
}