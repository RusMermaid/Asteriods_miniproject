using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace Asteroids
{
    public class SpaceShip : MovingEntity
    {
        protected ShipTemplate ship;
        protected Int32 current_health;
        protected Int32 maximum_health; //ship template
        protected Weapon weapon;
        protected Int64 last_shot_time;
        protected int shooting_delay; //ship template
        public bool shooting;
        public SpaceShip()
        {
            shooting = false;
            current_health = maximum_health;
        }
    }
}
