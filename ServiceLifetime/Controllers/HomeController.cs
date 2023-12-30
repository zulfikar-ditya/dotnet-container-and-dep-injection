using Microsoft.AspNetCore.Mvc;
using ServiceLifetime.Models;
using ServiceLifetime.Services;
using System.Diagnostics;
using System.Text;

namespace ServiceLifetime.Controllers
{
    public class HomeController : Controller
    {

        private readonly SingletonGuidServiceInterface _singletonGuidService_1;
        private readonly SingletonGuidServiceInterface _singletonGuidService_2;

        private readonly ScopeGuidServiceInterface _scopeGuidService_1;
        private readonly ScopeGuidServiceInterface _scopedGuidService_2;

        private readonly TransientGuidServiceInterface _transientGuidService_1;
        private readonly TransientGuidServiceInterface _transientGuidService_2;

        public HomeController(
            SingletonGuidServiceInterface singletonGuidService_1,
            SingletonGuidServiceInterface singletonGuidService_2,
            ScopeGuidServiceInterface scopeGuidService_1,
            ScopeGuidServiceInterface scopeGuidService_2,
            TransientGuidServiceInterface trasientGuidService_1,
            TransientGuidServiceInterface trasientGuidService_2
            )
        {
            _singletonGuidService_1 = singletonGuidService_1;
            _singletonGuidService_2 = singletonGuidService_2;

            _scopeGuidService_1 = scopeGuidService_1;
            _scopedGuidService_2 = scopeGuidService_2;

            _transientGuidService_1 = trasientGuidService_1;
            _transientGuidService_2 = trasientGuidService_2;

        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            StringBuilder message = new StringBuilder();

            message.Append("Singleton 1:" +  _singletonGuidService_1.GetGuid() + "\n");
            message.Append("Singleton 2:" +  _singletonGuidService_2.GetGuid() + "\n\n ");
            message.Append("Scope 1:" +  _scopeGuidService_1.GetGuid() + "\n");
            message.Append("Scope 2:" +  _scopedGuidService_2.GetGuid() + "\n\n ");
            message.Append("Transient 1:" +  _transientGuidService_1.GetGuid() + "\n");
            message.Append("Transient 2:" +  _transientGuidService_2.GetGuid());


            return Ok(message.ToString());
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
