namespace Mikater_project_1.Data.Models
{
    public class GameNews
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Img { get; set; }
        public bool IsActual { get; set; }
        public int GameId { get; set; }
    }
}
