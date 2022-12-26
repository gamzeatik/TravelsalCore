using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace TravelsalCore.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/Destination")]
    public class DestinationController : Controller
    {
        //DestinationManager destinationManager = new DestinationManager(new EfDestinationDal());
        private readonly IDestinationService _destinationService;

        public DestinationController(IDestinationService destinationService)
        {
            _destinationService = destinationService;
        }
        [Route("")]
        [Route("Index")]
        public IActionResult Index()
        {
            var values = _destinationService.TGetList();
            return View(values);
        }
        [Route("AddDestination")]
        [HttpGet]
        public IActionResult AddDestination()
        {
            return View();
        }
        [Route("AddDestination")]
        [HttpPost]
        public IActionResult AddDestination(Destination destination)
        {
            _destinationService.TAdd(destination);
            return RedirectToAction("Index");
        }
        [Route("DeleteDestination/{id}")]
        public IActionResult DeleteDestination(int id)
        {
            var values = _destinationService.TGetByID(id);
            _destinationService.TDelete(values);
            return RedirectToAction("Index", "Destination", new
            {
                area = "Admin"
            });
        }
        [Route("UpdateDestination/{id}")]
        [HttpGet]
        public IActionResult UpdateDestination(int id)
        {
            var values = _destinationService.TGetByID(id);
            return View(values);
        }
        [Route("UpdateDestination")]
        [HttpPost]
        public IActionResult UpdateDestination(Destination destination)
        {
            _destinationService.TUpdate(destination);
            return RedirectToAction("Index");
        }
    }
}
