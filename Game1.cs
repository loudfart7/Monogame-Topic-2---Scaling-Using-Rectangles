using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Reflection.Emit;

namespace Monogame_Topic_2___Scaling_Using_Rectangles
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        Texture2D rectangle;
        Rectangle rectRect;

        Texture2D circle;
        Rectangle circleRect;

        SpriteFont font;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
           
            _graphics.ApplyChanges();

            this.Window.Title = "Content, Scaling, and Text";

            rectRect = new Rectangle(700, 400, 75, 100);
            circleRect = new Rectangle(700, 400, 75, 100);

            base.Initialize();
        }

        protected override void LoadContent()
        {
            // TODO: use this.Content to load your game content here

            _spriteBatch = new SpriteBatch(GraphicsDevice);

            rectangle = Content.Load<Texture2D>("Images/rectangle");
            circle = Content.Load<Texture2D>("Images/circle");
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.SkyBlue);

            // TODO: Add your drawing code here

            _spriteBatch.Begin();

            _spriteBatch.Draw(rectangle, rectRect, Color.White);


            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
