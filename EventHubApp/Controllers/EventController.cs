using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EventHubApp.Models;
using EventHubApp.ViewModels;

namespace EventHubApp.Controllers
{
    public class EventController : Controller
    {
        private readonly ApplicationDbContext _db;

        public EventController()
        {
            _db = new ApplicationDbContext();
        }

        public ActionResult Create()
        {
            var viewModel = new EventFormViewModel()
            {
                Genres = _db.Genres.ToList()
            };
            return View(viewModel);
        }
    }
}