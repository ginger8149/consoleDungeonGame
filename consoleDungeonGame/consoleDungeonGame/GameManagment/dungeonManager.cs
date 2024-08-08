using consoleDungeonGame.GameManagment.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace consoleDungeonGame.GameManagment
{
    internal class dungeonManager
    {


        public dungeonManager() { }

        public void loadDungeonFromSave()
        {

        }

        public void saveDungeonToDisk() { }

        public dungeon generateNewDungeon(int difficulty)
        {

            Random rand = new Random();
            int numOfRoomsToExit = rand.Next(3,6) * difficulty;





        }

    }

}
