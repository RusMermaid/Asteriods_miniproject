using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace Asteroids
{
    public class MovingEntity : Sprite
    {
        protected float current_speed;
        protected float maximum_speed; //ship template
        protected float acceleration; //ship template
        protected Vector2 current_velocity;
        public MovingEntity()
        {

        }
    }
}
