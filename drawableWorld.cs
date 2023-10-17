using AgarioModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientGUI
{
    internal class drawableWorld : IDrawable
    {
        //Fields
        GraphicsView view;
        Dictionary<string, Player> playerObjects;
        IEnumerable<Food> foodObjects;

        public drawableWorld(GraphicsView gv, Dictionary<string, Player> players, IEnumerable<Food> food)
        {
            view         = gv;
            playerObjects = players;
            foodObjects   = food;
        }

        public void Draw(ICanvas canvas, RectF dirtyRect)
        {
            foreach(Player player in playerObjects.Values)
            {
                double radius = (3 * player.getMass()) / (4 * Math.PI);
                canvas.StrokeColor = Color.FromInt(player.getColor());
                canvas.StrokeSize = 2;
                canvas.FillColor = Color.FromInt(player.getColor());
                canvas.FillCircle(player.X, player.Y, (float)radius);
            }
            foreach(Food food in foodObjects)
            {
                double radius = (3 * food.getMass()) / (4 * Math.PI);
                canvas.StrokeColor = Color.FromInt(food.getColor());
                canvas.StrokeSize = 2;
                canvas.FillColor = Color.FromInt(food.getColor());
                canvas.FillCircle(food.X, food.Y, (float)radius);
            }
        }
    }
}
