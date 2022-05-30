using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Asteroids
{
    public abstract class Sprite
    {
        protected string texture_name;
       
        protected Rectangle source_rectangle;
        protected float rotation_speed;

        public Vector2 position;
        public Texture2D texture { get; set; }
        public Rectangle destination_rectangle { get; set; }
        public Color colour { get; set; }
        public float rotation { get; set; }
        public Vector2 rotation_origin { get ; set ; }
        public SpriteEffects facing { get; set; }
        public float scale { get; set; }
    }
}
