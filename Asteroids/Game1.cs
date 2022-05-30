using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;

namespace Asteroids
{
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        Stage currentStage;

        public static Settings.GameState game_state;
        public static KeyboardState keyboard_state;
        public static ContentManager content_loader;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        protected override void Initialize()
        {
            base.Initialize();
            Settings.resolution = new Point(1280, 720);
            graphics.PreferredBackBufferWidth = Settings.resolution.X;
            graphics.PreferredBackBufferHeight = Settings.resolution.Y;
            graphics.ApplyChanges();
            content_loader = Content;
            game_state = Settings.GameState.loading;
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
        }

        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        protected override void Update(GameTime gameTime)
        {
            keyboard_state = Keyboard.GetState();
            switch (game_state)
            {
                case Settings.GameState.menu:
                    {
                        if (keyboard_state.IsKeyDown(Keys.Space))
                        {
                            game_state = Settings.GameState.loading;
                        }
                        break;
                    }
                case Settings.GameState.loading:
                    {
                        try
                        {
                            currentStage = new Stage();
                            game_state = Settings.GameState.playing;
                        }
                        catch (System.Exception e)
                        {

                        }
                        break;
                    }
                case Settings.GameState.playing:
                    {
                        currentStage.Update();
                        break;
                    }
            }

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);
            spriteBatch.Begin();
            switch (game_state)
            {
                case Settings.GameState.menu:
                    {

                        break;
                    }
                case Settings.GameState.loading:
                    {

                        break;
                    }
                case Settings.GameState.playing:
                    {                       
                        currentStage.Draw(ref spriteBatch);
                        break;
                    }
            }
            spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
