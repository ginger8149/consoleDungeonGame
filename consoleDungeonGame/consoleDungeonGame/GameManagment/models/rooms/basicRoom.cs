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

            List<bool> validDirections = [true, true, true, true]; // n,s,e,w
            if (roomNorth.HasValue)
                validDirections[0] = false;
            else
            {
                foreach (IRoom room in currentMap)
                {
                    if((roomPosX == room.roomPosX) && (roomPosY +1 == roomPosY))
                        validDirections[0] = false;
                }
            }

            if (roomSouth.HasValue)
                validDirections[1] = false;
            else
            {
                foreach (IRoom room in currentMap)
                {
                    if ((roomPosX == room.roomPosX) && (roomPosY + 1 == roomPosY))
                        validDirections[0] = false;
                }
            }

            if (roomEast.HasValue)
                validDirections[2] = false;
            else
            {
                foreach (IRoom room in currentMap)
                {
                    if ((roomPosX == room.roomPosX) && (roomPosY + 1 == roomPosY))
                        validDirections[0] = false;
                }
            }

            if (roomWest.HasValue)
                validDirections[3] = false;
            else
            {
                foreach (IRoom room in currentMap)
                {
                    if ((roomPosX == room.roomPosX) && (roomPosY + 1 == roomPosY))
                        validDirections[0] = false;
                }
            }

            // pick a side any side
            int sidePicked = random.Next(0,validDirections.Count(c => c));
            







            //list of all posible rooms //todo: add exitRoomGeneration and waghting to room types 
            List<IRoom> roomTypes = [
                new basicRoom(),//add random name gen
            ];
            IRoom newRoom = roomTypes[random.Next(1, roomTypes.Count())];


            return newRoom; 


        }



    }
}
