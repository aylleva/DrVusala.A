using DoctorMVC.Services;
using DoctorMVC.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace DoctorMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ProceduresApiService _proservice;
        private readonly SlidesGetApiService _slideservice;

        public HomeController(ProceduresApiService proservice,SlidesGetApiService slideservice)
        {
          _proservice = proservice;
            _slideservice = slideservice;
        }
        public async Task<IActionResult> Index()
        {
            HomeVM homevm = new HomeVM()
            {
                Procedures =  _proservice.GetAllProcedures().Result.Take(6),
                Slides= _slideservice.GetAllSlides().Result.Where(s=>s.IsMain==true)
                
            };
            return View(homevm);
        }
    }
}
