using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using LHPet.Models;
using System.Collections.Generic;

namespace LHPet.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var listaClientes = new List<Cliente>()
            {
                new Cliente(01, "Arthur A. Ferreira", "857.032.950-41", "arthur.antunes@sp.senai.br", "Madruga"),
                new Cliente(02, "William Henry Gates III", "039.618.250-09", "bill@microsoft.com", "Bug"),
                new Cliente(03, "Ada Lovelace", "800.777.920-50", "ada@ada.language.com", "Byron"),
                new Cliente(04, "Linus Torvalds", "933.622.400-03", "torvalds@osdl.org", "Pinguim"),
                new Cliente(05, "Grace Hopper", "911.702.988-00", "grace.hopper@cobol.com", "Loboc")
            };

            var listaFornecedores = new List<Fornecedor>()
            {
                new Fornecedor(01, "C# PET S/A", "14.182.102/0001-80", "c-sharp@pet.org"),
                new Fornecedor(02, "Ctrl Alt Dog", "15.836.698/0001-57", "ctrl@alt.dog.br"),
                new Fornecedor(03, "BootsPet INC", "40.810.224/0001-83", "boots.pet@gatomania.us"),
                new Fornecedor(04, "Tik Tok Dogs", "87.945.350/0001-09", "noisnamidia@tiktokdogs.uk"),
                new Fornecedor(05, "Bifinho Forever", "18.760.614/0001-37", "contato@bff.us")
            };

            ViewBag.listaClientes = listaClientes;
            ViewBag.listaFornecedores = listaFornecedores;

            return View();
        }
        
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
{
    return View(new ErrorViewModel { RequestId = HttpContext.TraceIdentifier });
}
    }
}