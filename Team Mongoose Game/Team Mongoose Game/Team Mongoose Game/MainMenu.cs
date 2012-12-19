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
    class MainMenu
    {
        Button[] buttons = new Button[5];

        public void Initilize()
        {
            buttons[0] = new Button(new Vector2(200, 200), "Play", 100, 100);
        }

        public void Update()
        {
            foreach(Button b in buttons)
            {
                if (Mouse.GetState().X > b.rect.X && Mouse.GetState().X < (b.rect.X + b.rect.Height) && Mouse.GetState().Y > b.rect.Y && Mouse.GetState().Y < (b.rect.Y + b.rect.Width))
                {
                    Console.WriteLine("Button Press");
                }
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            foreach(Button b in buttons)
            {
                b.Draw(spriteBatch);
            }
        }
    }
}
