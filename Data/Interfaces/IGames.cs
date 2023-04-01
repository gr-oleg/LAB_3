using Mikater_project_1.Data.Models;

namespace Mikater_project_1.Data.Interfaces
{
    public interface IGames
    {
        IEnumerable<Games> AllGames { get; }
    }
}
