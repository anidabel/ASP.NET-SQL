using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Players.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Players.Controllers
{
    public class HomeController : Controller
    {
        PlayerContext db;
        public HomeController(PlayerContext context)
        {
            db = context;
        }
        public IActionResult Index()
        {
            return View(db.players.ToList());
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public String Add(Player pl)
        {
            if (db.players.Find(pl.PlayerId) != null)
            {
                return "Игрок НЕ добавлен, т.к. поле PlayerID должно быть уникальным, с таким ID игрок уже записан в БД";
            }
            if ((pl.BirthDay > new DateTime(2001, 01, 01) && pl.Height < 180 && pl.Weigth > 85)
                || (pl.BirthDay < new DateTime(2001, 01, 01) && pl.BirthState == "RU" && pl.Height < 170)
                || (pl.BirthDay > new DateTime(2015, 01, 01))
                || (pl.Weigth < 50)
                || (pl.Height < 150)
                || pl.Jersey < 0)
            {
                return "Игрок НЕ добавлен";
            }
            db.players.Add(pl);
            //сщхраняем в бд изменения
            db.SaveChanges();
            return "Игрок добавлен";

        }
    }
}
