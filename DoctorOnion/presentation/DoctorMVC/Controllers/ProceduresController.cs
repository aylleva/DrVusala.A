using DoctorMVC.Services;
using DoctorMVC.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace DoctorMVC.Controllers
{
    public class ProceduresController : Controller
    {
        private readonly ProceduresApiService service;

        public ProceduresController(ProceduresApiService service)
        {
            this.service = service;
        }
        public IActionResult Index()
        {
            ProcedureVm vm = new ProcedureVm()
            {
                ProcedureItems = service.GetAllProcedures().Result,
            };
            return View(vm);
        }
    }
}
