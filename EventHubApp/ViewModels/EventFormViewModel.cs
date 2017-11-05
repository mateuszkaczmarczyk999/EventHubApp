using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EventHubApp.Models;

namespace EventHubApp.ViewModels
{
    public class EventFormViewModel
    {
        public string Venue { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public int Genre { get; set; }
        public IEnumerable<Genre> Genres { get; set; }
    }
}