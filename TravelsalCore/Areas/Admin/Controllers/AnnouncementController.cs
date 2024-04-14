using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TravelsalCore.Areas.Admin.Models;

namespace TravelsalCore.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]

    public class AnnouncementController : Controller
    {
        private readonly IAnnouncementService _announcementService;

        public AnnouncementController(IAnnouncementService announcementService)
        {
            _announcementService = announcementService;
        }

        public IActionResult Index()
        {
            List<Announcement> announcements = new List<Announcement>();
            List<AnnouncementListViewModel> list = new List<AnnouncementListViewModel>();
            foreach (var item in announcements)
            {
                AnnouncementListViewModel announcementListViewModel = new AnnouncementListViewModel();
                announcementListViewModel.Id = item.AnnouncementId;
                announcementListViewModel.Title = item.Title;
                announcementListViewModel.Content = item.Content;

                list.Add(announcementListViewModel);
            }
            return View(list);
        }
        [HttpGet]
        public IActionResult AddAnnouncement()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddAnnouncement(string x)
        {
            return View();
        }
    }
}
