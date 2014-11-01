using System.Collections.Generic;

namespace SteamGameCategorization.Category
{
    internal class Genre
    {
        private int _id;
        private string _genre;

        private static Dictionary<int, Genre> _genres = new Dictionary<int, Genre>();

        public static Dictionary<int, Genre> Genres
        {
            get
            {
                return _genres;
            }
        }

        public static Genre NULL = new Genre(-1, "NULL");
        public static Genre Action = new Genre(1, "Action");
        public static Genre Strategy = new Genre(2, "Strategy");
        public static Genre RPG = new Genre(3, "RPG");
        public static Genre Casual = new Genre(4, "Casual");
        public static Genre Racing = new Genre(9, "Racing");
        public static Genre Sports = new Genre(18, "Sports");
        public static Genre Indie = new Genre(23, "Indie");
        public static Genre Adventure = new Genre(25, "Adventure");
        public static Genre Simulation = new Genre(28, "Simulation");
        public static Genre MassivelyMultiPlayer = new Genre(29, "Massively Multiplayer");
        public static Genre FreeToPlay = new Genre(37, "Free to Play");
        public static Genre EarlyAccess = new Genre(70, "Early Access");

        private Genre(int id, string genre)
        {
            _id = id;
            _genre = genre;
            _genres.Add(id, this);
        }

        public static Genre GetGenreByID(int id)
        {
            if (!_genres.ContainsKey(id))
                return NULL;
            return _genres[id];
        }

        public static Genre GetGenreByID(string id)
        {
            int idNum;
            if (int.TryParse(id, out idNum))
            {
                if (_genres.ContainsKey(idNum))
                    return _genres[idNum];
            }
            return NULL;
        }

        public override string ToString()
        {
            return _genre;
        }
    }
}
