using Microsoft.Extensions.Logging;

namespace AgarioModels
{
    public class AgarioWorld
    {
        //Fields
        private readonly int worldHeight;
        private readonly int worldWidth;
        private Dictionary<string, Player> playerList;
        private List<Food> foodList;
        private ILogger logger;

        public AgarioWorld(ILogger logger)
        {
            this.logger = logger;
            worldHeight = 5000;
            worldWidth  = 5000;
            playerList  = new Dictionary<string, Player>();
            foodList    = new List<Food>();
        }

        public Dictionary<string, Player> getPlayers()
        {
            return playerList;
        }

        public List<Food> getFood()
        {
            return foodList;
        }

        public void addItemToList(GameObject item)
        {
            if (item != null && item.GetType() == typeof(Player))
                playerList.Add((item as Player).getName(), (item as Player));
            else
                foodList.Add(item as Food);
        }
    }
}