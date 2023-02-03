using eTickets.Data;
using eTickets.Data.Services;
using eTickets.Models;
using Microsoft.AspNetCore.Mvc;

namespace eTickets.Controllers
{
    public class ActorsController : Controller
    {
        private readonly IActorsService _service;

        public ActorsController(IActorsService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index() // So async here and in method create, will run at the same time
                                                 //Because they are both connected to same button and are both
                                                 //a task the uses async with an await option
                                                 // In this case, create could be a normal IActionResult
        {
            var data = await _service.GetAllAsync();

            return View(data);
        }
        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create([Bind("FullName,ProfilePictureURL,Bio")]Actor actor)
        {
            if(!ModelState.IsValid)
            {
                return View(actor);
            }
           
           await _service.AddAsync(actor);
            return RedirectToAction(nameof(Index));
          
        }
        //Get : Actors/Deatils/1
        public async Task<IActionResult> Details(int id)
        {
            var actorDetails = await _service.GetByIdAsync(id);
            if (actorDetails == null) return View("Empty");
            return View(actorDetails);
        }
    }
}
