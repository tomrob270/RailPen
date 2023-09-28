using Bulky.DataAccess.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;
using RailPen.Models;
using System.Diagnostics;

namespace RailPen.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IMemberRepository _memberRepository;
        public HomeController(ILogger<HomeController> logger, IMemberRepository db)
        {
            _logger = logger;
            _memberRepository = db;
        }

        public IActionResult Index()
        {
            List<Member> list = _memberRepository.GetAll().ToList();
            return View(list);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
