using Mikater_project_1.Data.Interfaces;
using Mikater_project_1.Data.Models;

namespace Mikater_project_1.Data.Mocks
{
    public class Mock_Games : IGames
    {
        public IEnumerable<Games> AllGames
        {
            get
            {
                return new List<Games>
                {
                    new Games {GameName = "Cs:Go", Category = "Shooter", Description = "Wery good Game", GameVersion = "2"},
                    new Games {GameName = "Fortnite", Category = "Battle-Royale", Description = "Wery good Game x2", GameVersion = "13"},
                    new Games {GameName = "Minecraft", Category = "Survival", Description = "Wery good Game x3", GameVersion = "1.13.2"},
                    new Games {GameName = "Code-Storm", Category = "platformer", Description = "Wery good Game x4", GameVersion = "Beta"}
                };
            }
        }
    }
}
