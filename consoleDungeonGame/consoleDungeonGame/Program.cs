using consoleDungeonGame.UIManagment;

namespace consoleDungeonGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uiRenderer Renderer = new uiRenderer();

            Renderer.reRenderGameScreen();
        }
    }
}

