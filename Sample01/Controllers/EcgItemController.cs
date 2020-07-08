using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Sample01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sample01.Controllers
{
    public class EcgItemController:Controller
    {
        private readonly EcgItem ecgitems;
        public EcgItemController(IOptions<EcgItem> option)
        {
            ecgitems = option.Value;
        }
        public IActionResult Index()
        {
           
            return View(new EcgItemViewModel { EcgItems = new List<EcgItem> { ecgitems} });
        }
    }
}
