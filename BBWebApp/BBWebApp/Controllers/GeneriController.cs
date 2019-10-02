using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BBWebApp.Data;
using Microsoft.AspNetCore.Mvc;

namespace BBWebApp.Controllers
{
    public class GeneriController : Controller
    {
        private readonly MagicContext _context;

        public GeneriController(MagicContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Generi);
        }
    }
}