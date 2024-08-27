using consoleDungeonGame.GameManagment.intefaces;
using consoleDungeonGame.GameManagment.models;
using consoleDungeonGame.GameManagment.models.rooms;
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

        public void loadDungeonFromSave() { }

        public void saveDungeonToDisk() { }

        public Dungeon generateNewDungeon(int difficulty)
        {

            Random rand = new Random();
            int RoomsToExit = rand.Next(3,6) * difficulty;


            List<IRoom> rooms = [new basicRoom(0, 0)];

            for (int i = 0; i < RoomsToExit; i++)
            {
                rooms.Add(rooms.Last().genNewAtachedRoom(false,rooms));
            }











            

            return new Dungeon();
        }

    }

}
