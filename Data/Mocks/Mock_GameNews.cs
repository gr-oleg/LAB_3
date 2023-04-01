using Mikater_project_1.Data.Interfaces;
using Mikater_project_1.Data.Models;

namespace Mikater_project_1.Data.Mocks
{
    public class Mock_GameNews : IGameNews
    {
        public IEnumerable<GameNews> GetNews { 
            get {
                return new List<GameNews>
                {
                    new GameNews { Title = "Вийшла нова кска",
                        Description = "КсГо на сорс 2 і нові смоки",
                        Img = "https://3dnews.ru/assets/external/illustrations/2023/03/22/1083857/0.jpg", 
                        GameId = 1, 
                        IsActual = true},
                    new GameNews { Title = "В майнкрафт додали 300 модів за 2 дні",
                        Description = "Майнкрафт з модами виходить на новий рівень",
                        Img = "https://m.media-amazon.com/images/M/MV5BMzgyZWEzMDgtMzI0YS00ZDMwLTllNjQtZjE3ZmVkNWM3YzliXkEyXkFqcGdeQXVyMTYxNzI4OTYx._V1_FMjpg_UX1000_.jpg",
                        GameId = 3,
                        IsActual = false},
                    new GameNews { Title = "Вийшов банан з Форта",
                        Description = "Фортнайт знову здивував",
                        Img = "https://cdn2.unrealengine.com/social-image-battlepass-3840x2160-19b42864f188.jpg",
                        GameId = 2,
                        IsActual = true},
                }; 
            }
        }
        public IEnumerable<GameNews> GetActualNews { get; set; }

        public GameNews GetNew(int NewId)
        {
            throw new NotImplementedException();
        }
    }
}
