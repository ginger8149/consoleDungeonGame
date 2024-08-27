using consoleDungeonGame.GameManagment.intefaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleDungeonGame.GameManagment.models.rooms
{
    internal class startRoomq : IRoom
    {
        public Guid roomID => throw new NotImplementedException();

        public string roomName => throw new NotImplementedException();

        public int roomPosX => throw new NotImplementedException();

        public int roomPosY => throw new NotImplementedException();

        public Guid? roomNorth { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Guid? roomSouth { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Guid? roomEast { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Guid? roomWest { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public IRoom genNewAtachedRoom(bool ExitRoom, List<IRoom> currentMap)
        {
            throw new NotImplementedException();
        }
    }
}
