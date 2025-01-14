using Learningcs.Data;
using Learningcs.Models;
using Microsoft.AspNetCore.Mvc;

namespace Learningcs.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _context;
        public CategoryController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: CategoryController
        public ActionResult Index()
        {
            List<Category> categories = _context.Categories.ToList();   
            return View(categories);
        }

        // Create new category
        // GET: CategoryController/Create
        public ActionResult Create()
        {
            return View();
        }

    }
}
