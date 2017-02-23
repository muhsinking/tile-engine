using System;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
namespace TileCombat
{
	public class SpriteClass : DrawableGameComponent 
	{
		public int X { get; set; }
		public int Y { get; set; }
		public int angle { get; set; }
		public float scale { get; set; }
		public int dX { get; set; }
		public int dY { get; set; }
		public int dAngle { get; set; }
		public float dScale { get; set; }
		public Texture2D texture { get; }

		public SpriteClass(Game game,  string textureName, int X, int Y, float scale) : base(game)
		{
			this.X = X;
			this.Y = Y;
			this.scale = scale;

			// Load the specified texture
			texture = game.Content.Load<Texture2D>(textureName);
		}

		//public void LoadContent()

		public void Draw(SpriteBatch spriteBatch)
		{
			// Determine the position vector of the sprite
			Vector2 spritePosition = new Vector2(this.X, this.Y);

			// Draw the sprite
			spriteBatch.Draw(texture, spritePosition, null, Color.White, this.angle, new Vector2(texture.Width / 2, texture.Height / 2), new Vector2(scale, scale), SpriteEffects.None, 0f);
		}

	}
}
