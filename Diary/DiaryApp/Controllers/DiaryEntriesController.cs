using DiaryApp.Data;
using DiaryApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace DiaryApp.Controllers
{
    public class DiaryEntriesController : Controller
    {
        private ApplicationDbContext _db;
        public DiaryEntriesController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            List<DiaryEntry> entires = _db.DiaryEntries.ToList();

            return View(entires);
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}
