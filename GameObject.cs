using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace AgarioModels
{
    public class GameObject
    {
        //Fields
        private readonly long id;
        private Vector2 location;
        private int objectColor;
        private float mass;

        public float X
        {
            get { return location.X; }
            private set { ; }
        }

        public float Y
        {
            get { return location.Y; }
            private set { ; }
        }

        public GameObject()
        {
            location.X = 0;
            location.Y = 0;
            mass = 50;
            objectColor = 255;
        }

        public int getColor()
        {
            return objectColor;
        }

        public float getMass()
        {
            return mass;
        }
    }
}
