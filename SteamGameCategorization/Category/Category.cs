using System.Collections.Generic;

namespace SteamGameCategorization.Category
{
    internal class Category
    {
        private int _id;
        private string _category;

        private static Dictionary<int, Category> _categories = new Dictionary<int, Category>();

        public static Dictionary<int, Category> Categories
        {
            get
            {
                return _categories;
            }
        }

        public static Category NULL = new Category(-1, "NULL");
        public static Category MultiPlayer = new Category(1, "Multi-player");
        public static Category SinglePlayer = new Category(2, "Single-player");
        public static Category VAC = new Category(8, "Valve Anti-Cheat enabled");
        public static Category CoOp = new Category(9, "Co-op");
        public static Category MMO = new Category(20, "MMO");
        public static Category SteamAchievements = new Category(22, "Steam Achievements");
        public static Category SteamCloud = new Category(23, "Steam Cloud");
        public static Category LocalCoOp = new Category(24, "Local Co-op");
        public static Category CrossPlatformMultiPlayer = new Category(27, "Cross-Platform Multiplayer");
        public static Category FullControllerSupport = new Category(28, "Full controller support");
        public static Category SteamTradingCards = new Category(29, "Steam Trading Cards");
        public static Category SteamWorkshop = new Category(30, "Steam Workshop");

        private Category(int id, string category)
        {
            _id = id;
            _category = category;
            _categories.Add(id, this);
        }

        public static Category GetCategoryByID(int id)
        {
            if (!_categories.ContainsKey(id))
                return NULL;
            return _categories[id];
        }

        public static Category GetCategoryByID(string id)
        {
            int idNum;
            if (int.TryParse(id, out idNum))
            {
                if (_categories.ContainsKey(idNum))
                    return _categories[idNum];
            }
            return NULL;
        }

        public override string ToString()
        {
            return _category;
        }
    }
}
