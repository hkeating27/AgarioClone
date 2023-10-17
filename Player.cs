using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgarioModels
{
    public class Player : GameObject
    {
        //Field
        private string name;

        public Player(string name) : base()
        {
            this.name = name;
        }

        public string getName()
        {
            return name;
        }
    }
}
