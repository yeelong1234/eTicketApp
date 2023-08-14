using eTicketApp.Data;
using eTicketApp.Data.Services;
using Microsoft.AspNetCore.Mvc;

namespace eTicketApp.Controllers
{
    public class ActorsController : Controller
    {
        private readonly IActorsService _service;

        public ActorsController(IActorsService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAll();
            return View(data);
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}
