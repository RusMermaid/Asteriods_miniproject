using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace Asteroids
{
    public static class Settings
    {
        public static Point resolution;
        
        public enum GameState
        {
            menu,
            loading,
            playing
        }
    }
}
