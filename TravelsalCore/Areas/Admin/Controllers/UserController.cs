using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TravelsalCore.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/User")]
    [Authorize(Roles = "Admin")]

    public class UserController : Controller
    {
        private readonly IAppUserService _appUserService;
        private readonly IReservationService _reservationService;

        public UserController(IAppUserService appUserService, IReservationService reservationService)
        {
            _appUserService = appUserService;
            _reservationService = reservationService;
        }
        [Route("")]
        [Route("Index")]
        public IActionResult Index()
        {
            var values = _appUserService.TGetList();
            return View(values);
        }
        [Route("DeleteUser/{id}")]
        public IActionResult DeleteUser(int id)
        {
            var values = _appUserService.TGetByID(id);
            _appUserService.TDelete(values);
            return RedirectToAction("Index", "User", new
            {
                area = "Admin"
            });
        }
        [Route("EditUser/{id}")]
        [HttpGet]
        public IActionResult EditUser(int id)
        {
            var values= _appUserService.TGetByID(id);
            return View(values);
        }
        [Route("EditUser")]
        [HttpPost]
        public IActionResult EditUser(AppUser appUser)
        {
            _appUserService.TUpdate(appUser);
            return RedirectToAction("Index", "User", new
            {
                area = "Admin"
            });
        }
        [Route("CommentUser/{id}")]
        public IActionResult CommentUser(int id)
        {
            _appUserService.TGetList();
            return View();
        }
        [Route("ReservationUser/{id}")]
        public IActionResult ReservationUser(int id)
        {
           var values= _reservationService.GetListWithReservationByAccepted(id);
            return View(values);
        }
    }
}
