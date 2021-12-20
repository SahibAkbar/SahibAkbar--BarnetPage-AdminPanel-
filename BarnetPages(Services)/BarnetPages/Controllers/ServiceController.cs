using BarnetPages.Data;
using BarnetPages.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BarnetPages.Controllers
{
    public class ServiceController : Controller
    {
        private readonly AppDbContext _context;

        public ServiceController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            VmService model = new VmService();
            model.Services = _context.Services.ToList();
            model.Clients = _context.Clients.ToList();
            model.Setting = _context.Settings.FirstOrDefault();
            model.Socials = _context.Socials.ToList();
            model.Subscribe = _context.Subscribes.FirstOrDefault();

            return View(model);
        }
    }
}
