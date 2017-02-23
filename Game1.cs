using System;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Input;


namespace TileCombat
{
	public class Game1 : Game
	{
		GraphicsDeviceManager graphics;
		SpriteBatch spriteBatch;
		SpriteClass tile;
		float screenHeight;
		float screenWidth;

		float screenscale;
		
		public Game1()
		{
			graphics = new GraphicsDeviceManager(this);
			Content.RootDirectory = "Content";
			if (!graphics.IsFullScreen)
				graphics.ToggleFullScreen();		}


		protected override void Initialize()
		{
			screenscale = 2880f / 1440f;

			//screenWidth = GraphicsDevice.DisplayMode.Width;
			//screenHeight = GraphicsDevice.DisplayMode.Height;

			screenHeight = GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Height * screenscale;
			screenWidth = GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Width * screenscale;

			//float scale = ScaleToHighDPI(screenWidth);

			//Console.WriteLine("Width = " + screenWidth);
			//this.Window.AllowUserResizing = true;
			//this.Window.ClientSizeChanged += new EventHandler<EventArgs>(Window_ClientSizeChanged);


			//graphics.PreferredBackBufferHeight =  900 * (int) screenscale;
			//graphics.PreferredBackBufferWidth = 1440 * (int) screenscale;
			//graphics.ApplyChanges();
			base.Initialize();
		}

		public float ScaleToHighDPI(int width)
		{
			//int trueWidth = this.GraphicsDevice.Viewport.Width;
			int trueWidth = Window.ClientBounds.Width;
			Console.WriteLine(trueWidth);

			int trueHeight = this.GraphicsDevice.Viewport.Height;


			float ret = trueWidth / width;
			Console.WriteLine(ret);
			//DisplayInformation d = DisplayInformation.GetForCurrentView();
			//f *= (float)d.RawPixelsPerViewPixel;
			return ret;
		}


		protected override void LoadContent()
		{
			// Create a new SpriteBatch, which can be used to draw textures.
			spriteBatch = new SpriteBatch(GraphicsDevice);

			//grass = Content.Load<Texture2D>("grass-0");

			tile = new SpriteClass(this, "grass-0", 300 * (int) screenscale, 300 * (int) screenscale, 3f * screenscale);
		}


		protected override void Update(GameTime gameTime)
		{
			
			base.Update(gameTime);
		}

		protected override void Draw(GameTime gameTime)
		{
			graphics.GraphicsDevice.Clear(Color.CornflowerBlue);

			spriteBatch.Begin(SpriteSortMode.Deferred, BlendState.AlphaBlend, SamplerState.PointClamp, null, null, null, null);

			//spriteBatch.Draw(grass, new Vector2(100, 100));
			tile.Draw(spriteBatch);

			spriteBatch.End();



			base.Draw(gameTime);
		}
	}
}
