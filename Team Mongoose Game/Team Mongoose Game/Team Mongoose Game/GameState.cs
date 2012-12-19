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
    class GameState
    {
        enum States { MainMenu, Running, Paused, Credits };

        States current;
        MainMenu menu;

        public void Initilize()
        {
            current = States.MainMenu;
            menu = new MainMenu();
            menu.Initilize();
        }

        public void Update()
        {
            switch(current){
                case States.MainMenu:
                    UpdateMenu();
                    break;
                case States.Running:
                    UpdateRunning();
                    break;
                case States.Paused:
                    UpdatePaused();
                    break;
                case States.Credits:
                    UpdateCredits();
                    break;
                default:
                    UpdateMenu();
                    break;
            }

        }
        public void Draw(SpriteBatch spriteBatch)
        {
            switch (current)
            {
                case States.MainMenu:
                    DrawMenu(spriteBatch);
                    break;
                case States.Running:
                    DrawRunning(spriteBatch);
                    break;
                case States.Paused:
                    DrawPaused(spriteBatch);
                    break;
                case States.Credits:
                    DrawCredits(spriteBatch);
                    break;
                default:
                    DrawMenu(spriteBatch);
                    break;
            }
        }

        //TODO: Calls to drawing and updating are put in here. Preferebally to other classes that contain game controls 

        public void UpdateMenu()
        {
            menu.Update();
        }
        public void UpdateRunning()
        {

        }
        public void UpdatePaused()
        {

        }
        public void UpdateCredits()
        {

        }


        public void DrawMenu(SpriteBatch spriteBatch)
        {
            menu.Draw(spriteBatch);
        }
        public void DrawRunning(SpriteBatch spriteBatch)
        {

        }
        public void DrawPaused(SpriteBatch spriteBatch)
        {

        }
        public void DrawCredits(SpriteBatch spriteBatch)
        {

        }
    }
}
