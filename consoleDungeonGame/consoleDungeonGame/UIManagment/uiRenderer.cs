using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleDungeonGame.UIManagment
{
    internal class uiRenderer
    {

        internal int MaxHeight { get; set; }
        internal int MaxWidth { get; set; }



        //Minimap window render pos infomation
        internal int MiniMapPosX { get; set; }
        internal int MiniMapPosY { get; set; }
        internal int MiniMapWidth { get; set; }
        internal int MiniMapHeight { get; set; }


        public void reRenderGameScreen()
        {

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            // get max with and height

            MaxHeight = Console.WindowHeight;
            MaxWidth = Console.WindowWidth;




            // draw border
            
            //reset cursor pos
            Console.SetCursorPosition(0, 0);

            // draw top bar
            Console.Write("\u250F");
            for (int i = 0; i < (MaxWidth-2); i++)
            {
                Console.Write("\u2501");
            }
            Console.Write("\u2513");
            
            //draw side bars
            for (int i = 1; i < (MaxHeight-1); i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write("\u2503");
                Console.SetCursorPosition(MaxWidth-1, i);
                Console.Write('\u2503');
            }

            // draw bottom bar
            Console.SetCursorPosition(0, MaxHeight-1);
            Console.Write("\u2517");
            for (int i = 0; i < (MaxWidth - 2); i++)
            {
                Console.Write("\u2501");
            }
            Console.Write("\u251B");



            // devide screen and store area 
            MiniMapWidth = MaxWidth / 4;
            MiniMapHeight = MaxHeight / 4;

            MiniMapPosX = MaxWidth - MiniMapWidth;
            MiniMapPosY = MaxHeight - MiniMapHeight;

            //draw deviding bar
            Console.SetCursorPosition(MiniMapPosX, 0);
            Console.Write('\u2533');
            for (int i = 1; i < (MaxHeight-1); i++)
            {
                Console.SetCursorPosition(MiniMapPosX, i);
                Console.Write('\u2503');
            }
            Console.SetCursorPosition(MiniMapPosX, MaxHeight-1);
            Console.Write('\u253B');



            Console.SetCursorPosition(MaxWidth -1,MaxHeight-1);
        }
        public void renderDungeonRoom() 
        {

        }
        public void renderDungeonMap()
        {

        }




    }
}
