using System.Diagnostics;
using Asp_Services.Models;
using Microsoft.AspNetCore.Mvc;

namespace Asp_Services.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private STLifeTimeCheck st_lifeTime_1;
        private STLifeTimeCheck st_lifeTime_2;

        private SCLifeTimeCheck sC_lifeTime_1;
        private SCLifeTimeCheck sC_lifeTime_2;

        private TRLifeTimeCheck tr_lifeTime_1;
        private TRLifeTimeCheck tr_lifeTime_2;

        public HomeController(ILogger<HomeController> logger,
            STLifeTimeCheck st_lifeTime_1,
            STLifeTimeCheck st_lifeTime_2,

            SCLifeTimeCheck sC_lifeTime_1,
            SCLifeTimeCheck sC_lifeTime_2,

            TRLifeTimeCheck tr_lifeTime_1,
            TRLifeTimeCheck tr_lifeTime_2
            )
        {
            _logger = logger;
           this.st_lifeTime_1 = st_lifeTime_1;
           this.st_lifeTime_2 = st_lifeTime_2;

           this.sC_lifeTime_1 = sC_lifeTime_1;
            this.sC_lifeTime_2 = sC_lifeTime_2;

            this.tr_lifeTime_1 = tr_lifeTime_1;
            this.tr_lifeTime_2 = tr_lifeTime_2;
        }

        public Object Index()
        {
            return new
            {
                SingleTon_1 = st_lifeTime_1.id,
                SingleTon_2 = st_lifeTime_2.id,
                Scoped_1 = sC_lifeTime_1.id,
                Scoped_2 = sC_lifeTime_2.id,
                Transient_1 = tr_lifeTime_1.id,
                Transient_2 = tr_lifeTime_2.id
            };
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
