using Microsoft.AspNetCore.Mvc;
using Mikater_project_1.Data.Interfaces;

namespace Mikater_project_1.Controllers
{
    public class GameNewsController : Controller
    {
        private readonly IGameNews _gameNews;
        private readonly IGames _games;

        public GameNewsController (IGameNews gameNews, IGames games)
        {
            _gameNews = gameNews;
            _games = games;
        }

        public ViewResult List()
        {
            var gameNews = _gameNews.GetNews;
            return View(gameNews);
        }
    }
}
