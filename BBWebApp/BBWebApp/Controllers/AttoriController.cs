using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BBWebApp.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BBWebApp.Controllers
{
    public class AttoriController : Controller
    {
        private readonly MagicContext _context;

        public AttoriController(MagicContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Attori);
        }
    }
}