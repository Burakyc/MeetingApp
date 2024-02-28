using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers
{
    public class HomeController:Controller
    {
        public IActionResult Index()
        {
            int saat = DateTime.Now.Hour;
            ViewBag.SayHello = saat > 12 ? "İyi günler":"Günaydın";
            int UserCount = Repository.Users.Where(i=>i.WillAttend == true).Count();

            var meetingInfo = new MeetingInfo()
            {
                Id=1,
                Location = "İstanbul Sancaktepe",
                Date = new DateTime(2023,11,15,0,0,0),
                NumberOfPeople = UserCount,
            };

            return View(meetingInfo);
        }
    }
}