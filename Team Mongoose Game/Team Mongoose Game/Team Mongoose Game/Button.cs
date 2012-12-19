using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace Team_Mongoose_Game
{
    class Button
    {
        public String text;
        public Rectangle rect = new Rectangle();

        public Button(Vector2 pos, String text, int width, int height)
        {
            this.text = text;
            rect = new Rectangle((int)pos.X,(int) pos.Y, width, height);
        }

        public void Draw(SpriteBatch spriteBatch)
        {

        }
    }
}
