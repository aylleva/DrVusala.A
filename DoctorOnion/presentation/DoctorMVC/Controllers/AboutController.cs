using DoctorMVC.Services;
using DoctorMVC.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace DoctorMVC.Controllers
{
    public class AboutController : Controller
    {
        private readonly ProceduresApiService service;

        public AboutController(ProceduresApiService service)
        {
            this.service = service;
        }
        public async Task<IActionResult> Index()
        {
            AboutVm vm = new AboutVm() { 
            ProcedureItems=   service.GetAllProcedures().Result.Where(p=>p.IsMain==true),
            };
            return View(vm);
        }
    }
}
