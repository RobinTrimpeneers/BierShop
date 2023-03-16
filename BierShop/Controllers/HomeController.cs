using BierShop.Models;
using BierShop.Persistence;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BierShop.Controllers
{
    public class HomeController : Controller
    {
        PersistenceCode pc = new PersistenceCode();
        [HttpGet]
        public IActionResult Index()
        {
            ProductRepository productrepo = new ProductRepository();
            productrepo.Producten = pc.LoadProducten();
            return View(productrepo);
        }


    }
}