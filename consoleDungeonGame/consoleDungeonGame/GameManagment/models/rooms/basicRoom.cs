using consoleDungeonGame.GameManagment.intefaces;
using System;
using System.Collections.Generic;
using System.Linq;
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
        public basicRoom() 
        {
            roomID = new Guid();
        }

        public IRoom genAtachedRoom(bool ExitRoom, List<IRoom> currentMap)
        {
            //list of all posible rooms
            List<IRoom> roomTypes= [
                new basicRoom(),
                ];
            IRoom newRoom = roomTypes[random.Next(1, roomTypes.Count())];
            
            //find place to attach new room if not throw exseption


            //todo check what directions are avalible to atatch to
            // start check by looking at what sides dont have ids then check empty directions posx,y for non atached rooms.
            



            return newRoom; 


        }



    }
}
