using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Team_Mongoose_Game
{
    class GameState
    {
        enum States { MainMenu, Running, Paused, Credits };

        States current;

        public void Initilize()
        {
            current = States.MainMenu;
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
        public void Draw()
        {
            switch (current)
            {
                case States.MainMenu:
                    DrawMenu();
                    break;
                case States.Running:
                    DrawRunning();
                    break;
                case States.Paused:
                    DrawPaused();
                    break;
                case States.Credits:
                    DrawCredits();
                    break;
                default:
                    DrawMenu();
                    break;
            }
        }

        //TODO: Calls to drawing and updating are put in here. Preferebally to other classes that contain game controls 

        public void UpdateMenu()
        {

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


        public void DrawMenu()
        {

        }
        public void DrawRunning()
        {

        }
        public void DrawPaused()
        {

        }
        public void DrawCredits()
        {

        }
    }
}
