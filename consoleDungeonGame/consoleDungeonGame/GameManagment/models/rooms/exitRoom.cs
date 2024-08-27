using consoleDungeonGame.GameManagment.intefaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleDungeonGame.GameManagment.models.rooms
{
    internal class exitRoom : IRoom
    {
        public Guid roomID => throw new NotImplementedException();

        public string roomName => throw new NotImplementedException();

        public int roomPosX => throw new NotImplementedException();

        public int roomPosY => throw new NotImplementedException();

        

        Guid? IRoom.roomNorth { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        Guid? IRoom.roomSouth { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        Guid? IRoom.roomEast { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        Guid? IRoom.roomWest { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public IRoom genNewAtachedRoom(bool ExitRoom, List<IRoom> currentMap)
        {
            throw new NotImplementedException();
        }
    }
}
