using Mikater_project_1.Data.Models;

namespace Mikater_project_1.Data.Interfaces
{
    public interface IGameNews
    {
        IEnumerable<GameNews> GetNews { get; }

        IEnumerable<GameNews> GetActualNews { get; set; }

        GameNews GetNew (int NewId);
    }
}
