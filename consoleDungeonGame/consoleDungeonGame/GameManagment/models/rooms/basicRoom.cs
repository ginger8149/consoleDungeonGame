using consoleDungeonGame.GameManagment.intefaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace consoleDungeonGame.GameManagment.models.rooms
{
    internal class basicRoom : IRoom
    {
        public Guid roomID {  get; set; }
        public string roomName { get; set; }

        public int roomPosX { get; set; }
        public int roomPosY { get; set; }

        public Guid? roomNorth { get; set; }
        public Guid? roomSouth { get; set; }
        public Guid? roomEast { get; set; }
        public Guid? roomWest { get; set; }

        Random random = new Random();
        public basicRoom( int x , int y) 
        {
            roomID = new Guid();
            roomName = "test:" + x +" "+ y;
            
            roomPosX = x;
            roomPosY = y;

        }

        public IRoom genNewAtachedRoom(bool ExitRoom, List<IRoom> currentMap)
        {
            //find place to attach new room if not throw exseption
            // start check by looking at what sides dont have ids then check empty directions posx,y for non atached rooms.
            List<KeyValuePair<string, bool>> validSides = [

                new KeyValuePair<string, bool>("North", !roomNorth.HasValue && currentMap.Exists(c => c.roomPosY == roomPosY + 1 && c.roomPosX == roomPosX) ),
                new KeyValuePair<string, bool>("South", !roomSouth.HasValue && currentMap.Exists(c => c.roomPosY == roomPosY - 1 && c.roomPosX == roomPosX)),
                new KeyValuePair<string, bool>("East", !roomEast.HasValue && currentMap.Exists(c => c.roomPosY == roomPosY && c.roomPosX == roomPosX + 1)),
                new KeyValuePair<string, bool>("West", !roomWest.HasValue && currentMap.Exists(c => c.roomPosY == roomPosY && c.roomPosX == roomPosX - 1))
            ];

            var valid = validSides.FindAll(C => C.Value);
            string pickedDirection = valid[random.Next(valid.Count)].Key;

            int newRoomPosX = roomPosX;
            int newRoomPosY = roomPosY;

            if (pickedDirection == "North")
                newRoomPosX = roomPosX + 1;
            if (pickedDirection == "South")
                newRoomPosX = roomPosX - 1;
            if (pickedDirection == "East")
                newRoomPosY = roomPosY + 1;
            if (pickedDirection == "West")
                newRoomPosY = roomPosY - 1;

            //list of all posible rooms //todo: add exitRoomGeneration and waghting to room types 
            List<IRoom> roomTypes = [
                new basicRoom(roomPosX,roomPosY),//add random name gen
            ];
            IRoom newRoom = roomTypes[random.Next(1, roomTypes.Count())];

            if (pickedDirection == "North")
                roomNorth = newRoom.roomID;
            if (pickedDirection == "South")
                roomSouth = newRoom.roomID;
            if (pickedDirection == "East")
                roomEast = newRoom.roomID;
            if (pickedDirection == "West")
                roomWest = newRoom.roomID;
            
            return newRoom; 


        }



    }
}
