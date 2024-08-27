using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleDungeonGame.GameManagment.intefaces
{
    internal interface IRoom
    {
        Guid roomID { get; }
        
        string roomName {  get; }


        public int roomPosX { get; }
        public int roomPosY { get; }

        // id 0 to be used if not conected
        public Guid? roomNorth { get; set; }
        public Guid? roomSouth { get; set; }
        public Guid? roomEast { get; set; }
        public Guid? roomWest { get; set; }

        public IRoom genNewAtachedRoom(bool ExitRoom, List<IRoom> currentMap);
        //TODO: add requred render information



    }       
}
