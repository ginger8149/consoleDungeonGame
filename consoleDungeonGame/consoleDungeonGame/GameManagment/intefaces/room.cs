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


        int roomPosX { get; }
        int roomPosY { get; }

        // id 0 to be used if not conected
        Guid? roomNorth { get; }
        Guid? roomSouth { get; }
        Guid? roomEast { get; }
        Guid? roomWest { get; }


        //TODO: add requred render information



    }       
}
