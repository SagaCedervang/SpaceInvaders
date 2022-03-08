using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace SpaceInvaders
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        SpriteBatch spriteBatch;
        Texture2D playerShipBild;
        Rectangle playerShipRectangle;

        Texture2D shipYellow_mannedBild;
        Rectangle shipYellow_mannedRectangle;

        KeyboardState tangentbord = Keyboard.GetState();

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
           

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            spriteBatch = new SpriteBatch(GraphicsDevice);

            playerShipBild = Content.Load<Texture2D>("playerShip");
            playerShipRectangle = new Rectangle(350, 420, playerShipBild.Width / 2, playerShipBild.Height / 2);
            shipYellow_mannedBild = Content.Load<Texture2D>("shipYellow_manned");
            shipYellow_mannedRectangle = new Rectangle(100, 200, shipYellow_mannedBild.Width / 4, shipYellow_mannedBild.Height / 4);
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
            tangentbord = Keyboard.GetState();


            if (tangentbord.IsKeyDown(Keys.Left) == true)
            {
                playerShipRectangle.X -= 5;
            }

            if (tangentbord.IsKeyDown(Keys.Right) == true)
            {
                playerShipRectangle.X += 5;
            }

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            spriteBatch.Begin();
            spriteBatch.Draw(playerShipBild, playerShipRectangle, Color.White);

            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
