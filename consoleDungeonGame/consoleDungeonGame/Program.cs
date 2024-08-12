using consoleDungeonGame.GameManagment;
using consoleDungeonGame.UIManagment;

namespace consoleDungeonGame
{
    internal class Program
    {
        static void Main(string[] args)
        {

            dungeonManager dungeonManager = new dungeonManager();

            dungeonManager.generateNewDungeon(2);



            //uiRenderer Renderer = new uiRenderer();

            //Renderer.reRenderGameScreen();
        }
    }
}

