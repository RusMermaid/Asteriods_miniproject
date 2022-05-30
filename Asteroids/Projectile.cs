using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Asteroids
{
    public class Projectile : MovingEntity
    {
        public Projectile(Vector2 _position, float _rotation)
        {
            texture = Game1.content_loader.Load<Texture2D>("plasma");
            position = _position;
            colour = Color.White;
            rotation_origin = new Vector2(texture.Width * 0.5f, texture.Height * 0.75f);
            rotation = _rotation;
            scale = 1f;
            current_speed = 12f;
            current_velocity.X = (float)Math.Sin(rotation) * current_speed;
            current_velocity.Y = -(float)Math.Cos(rotation) * current_speed;
        }
        public void Update()
        {
            position += current_velocity;
        }
    }
}
