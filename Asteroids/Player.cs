using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Asteroids
{
    public class Player : SpaceShip
    {
        int lives;
        Keys thrust_key;
        Keys rotate_clockwise_key;
        Keys rotate_anticlockwise_key;
        Keys shoot_key;
        public Player()
        {
            thrust_key = Keys.W;
            rotate_anticlockwise_key = Keys.A;
            rotate_clockwise_key = Keys.D;
            shoot_key = Keys.Space;
            lives = 3;
            current_health = 100;
            texture = Game1.content_loader.Load<Texture2D>("playerShip3_blue");
            position = new Vector2(620, 350);
            colour = Color.White;
            rotation_origin = new Vector2(texture.Width * 0.5f, texture.Height * 0.75f);
            rotation = 0;
            rotation_speed = 0.1f;
            scale = 1f;
            current_speed = 0.5f;
            current_velocity = Vector2.Zero;
            maximum_speed = 8f;
            acceleration = 0.1f;
            shooting_delay = 10;
        }
        public void Update(Int64 current_time)
        {
            if (Game1.keyboard_state.IsKeyDown(Keys.Q))
            {
                position = new Vector2(620, 350);
                rotation = 0;
                current_speed = 0.5f;
                current_velocity = Vector2.Zero;
            }
            if (Game1.keyboard_state.IsKeyDown(rotate_clockwise_key))
            {
                rotation += rotation_speed;
            }
            if (Game1.keyboard_state.IsKeyDown(rotate_anticlockwise_key))
            {
                rotation -= rotation_speed;
            }
            if (Game1.keyboard_state.IsKeyDown(shoot_key))
            {
                if (current_time - last_shot_time > shooting_delay)
                {
                    shooting = true;
                    last_shot_time = current_time;
                }                
            }
            if (Game1.keyboard_state.IsKeyDown(thrust_key))
            {
                current_velocity.X += (float)Math.Sin(rotation) * acceleration;
                current_velocity.Y -= (float)Math.Cos(rotation) * acceleration;
                current_speed = (float)Math.Sqrt(current_velocity.X * current_velocity.X + current_velocity.Y * current_velocity.Y); //pythagoras to ge speed from velocity
                if (current_speed > maximum_speed)
                {
                    current_velocity *=  maximum_speed / current_speed; // enforce speed limit
                }
            }
            position += current_velocity;
        }

    }
}
