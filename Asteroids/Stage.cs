using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;

namespace Asteroids
{
    public class Stage
    {
        private Int64 frame_counter;
        private Player player;
        private List<Enemy> enemies;
        private List<Projectile> projectiles;
        public Stage()
        {
            frame_counter = 0;
            enemies = new List<Enemy>();
            player = new Player();
            projectiles = new List<Projectile>();
        }
        public void Update()
        {
            frame_counter += 1;
            player.Update(frame_counter);
            WrapAroundScreen(player);
            if (player.shooting)
            {
                projectiles.Add(new Projectile(player.position, player.rotation));
                player.shooting = false;
            }
            foreach (Projectile p in projectiles)
            {
                p.Update();
            }
        }
        private void WrapAroundScreen(MovingEntity m)
        {
            if ((m.position.X + m.texture.Width) < 0)
            {
                m.position.X = Settings.resolution.X;
            }
            if (m.position.X > Settings.resolution.X)
            {
                m.position.X = 0 - m.texture.Width;
            }
            if ((m.position.Y + m.texture.Height) < 0)
            {
                m.position.Y = Settings.resolution.Y;
            }
            if (m.position.Y > Settings.resolution.Y)
            {
                m.position.Y = 0 - m.texture.Height;
            }
        }
        public void Draw(ref SpriteBatch spriteBatch)
        {            
            foreach (Projectile p in projectiles)
            {
                spriteBatch.Draw(p.texture, p.position, null, p.colour, p.rotation, p.rotation_origin, p.scale, p.facing, 0);
            }
            spriteBatch.Draw(player.texture, player.position, null, player.colour, player.rotation, player.rotation_origin, player.scale, player.facing, 0);
        }
    }
}
