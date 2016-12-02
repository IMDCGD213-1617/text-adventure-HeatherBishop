using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventure
{
    static class Level
    {
        //create rooms grid
        private static Rooms[,] rooms;  //2D array of type room

        public static Rooms[,] Room
        {
            get { return rooms; }
        }

        //Initialize()
        //Happens at start.
        //Creates rooms in the level.
        //Create Items and put them in rooms.
        //Take players location and place them in a room.
        public static void Initialize()
        {
            BuildLevel();

        }

        //BuildLevel()
        //
        private static void BuildLevel()
        {
            //set up grid to contain rooms
            rooms = new Rooms[7, 3]; //2 rooms x, 2 y = 4 rooms total

            //temp variables to contain room/item objects.
            Rooms room;
            Items item;



            //create the rooms

            #region house 0,0
            // create new room.
            room = new Rooms();

            // assign this room to location 0,0
            rooms[0, 0] = room;

            //Room proerties.
            room.RoomTitle = "House";
            room.RoomDescription = "You have entered the house.";

            // add an exit using the method, then assign direction.
            room.AddExit(Direction.East); //0,1 LOCATION
            room.AddExit(Direction.South); // 1,0 Location
#endregion

            #region forest 0,1
            //new room
            room = new Rooms();

            // assign this room to location 1,0
            rooms[0, 1] = room;

            //Room proerties.
            room.RoomTitle = "Forest";
            room.RoomDescription = "You have entered the Forest. The faint sound of dripping water comes from the east.";

            // add an exit using the method, then assign direction.
            room.AddExit(Direction.West); // add west direction to return to original location [0,0]
            room.AddExit(Direction.East); // east direction = 0,2 location
            room.AddExit(Direction.South); //south direction = 1,1 location

            //create new item in this room
            #region item Sword
            item = new Items();

            //set up the item
            item.ItemTitle = "Sword";
            item.ItemDescription = "You pick up a sword, it is cold to the touch and considerably more heavy than you thought";

            //add item to current room
            room.Items.Add(item);

            #endregion

            #endregion

            #region cave entrance 0,2

            //new room
            room = new Rooms();

            // assign this room to location
            rooms[0, 2] = room;

            //Room proerties.
            room.RoomTitle = "Cave Entrance";
            room.RoomDescription = "You have arrived at the Cave Entrance. The breeze from inside is cool against your skin.";

            // add an exit using the method, then assign direction.
            room.AddExit(Direction.West); // add west direction to return to original location [0,1]
            
            room.AddExit(Direction.South); //south direction = 1,2 location


            #endregion

            #region dense forest 1,0
            //new room
            room = new Rooms();

            // assign this room to location 1,0
            rooms[1, 0] = room;

            //Room proerties.
            room.RoomTitle = "Dense Forest";
            room.RoomDescription = "You have entered the Dense Forest.";

            // add an exit using the method, then assign direction.
            room.AddExit(Direction.North); // direction = 0,0
            room.AddExit(Direction.East); // direction = 1,1
            room.AddExit(Direction.South); //direction = 2,0
            

            //create new item
            #region item Axe
            item = new Items();

            //set up the item
            item.ItemTitle = "Axe";
            item.ItemDescription = "You pick up an Axe, its blade has recently been sharpened.";
            item.Weight = 1;

            //add item to current room
            room.Items.Add(item);


            #endregion

            #endregion

            #region tranquil clearing 1,1
            //new room
            room = new Rooms();

            // assign this room to location 1,0
            rooms[1, 1] = room;

            //Room proerties.
            room.RoomTitle = "Tranquil Clearing";
            room.RoomDescription = "You have entered the Tranquil Clearing.";

            // add an exit using the method, then assign direction.
            room.AddExit(Direction.North); // direction = 0,1
            room.AddExit(Direction.East); // direction = 1,1
            room.AddExit(Direction.South); //direction = 2,0



            #endregion

            #region large cave 1,2
            //new room
            room = new Rooms();

            // assign this room to location 1,0
            rooms[1,2] = room;

            //Room proerties.
            room.RoomTitle = "Large Cave";
            room.RoomDescription = "You have entered the Large Cave. It is dark and damp, your footsteps echo deafeningly in the silence.";

            // add an exit using the method, then assign direction.
            room.AddExit(Direction.North); // add east direction to return to original location [0,2]
            room.AddExit(Direction.West); // west direction = 1,1
            

            //create new item
            #region item Cauldron
            item = new Items();

            //set up the item
            item.ItemTitle = "Cauldron";
            item.ItemDescription = "You pick up a Cauldron, its smooth and heavy with a strange frothing liquid inside. The smell of sulphur fills the air.";
            item.Weight = 3;

            //add item to current room
            room.Items.Add(item);


            #endregion

            #endregion

            #region shallow lake 2,0
            //new room
            room = new Rooms();

            // assign this room to location 1,0
            rooms[2, 0] = room;

            //Room proerties.
            room.RoomTitle = "Shallow Lake";
            room.RoomDescription = "You have arrived at a Shallow Lake. You can see the lake bed beneath the pristine water.";

            // add an exit using the method, then assign direction.
            room.AddExit(Direction.North); // direction = 1,0
            room.AddExit(Direction.East); // direction = 2,1
            room.AddExit(Direction.South); //direction = 3,0


            #endregion

            #region sparse forest 2,1
            //new room
            room = new Rooms();

            // assign this room to location 1,0
            rooms[2, 1] = room;

            //Room proerties.
            room.RoomTitle = "Sparse Forest";
            room.RoomDescription = "You have arrived at a Sparse Forest.";

            // add an exit using the method, then assign direction.
            room.AddExit(Direction.North); // direction = 1,1
            room.AddExit(Direction.East); // direction = 2,2
            room.AddExit(Direction.South); //direction = 3,1


            #endregion

            #region murky lake 2,2
            //new room
            room = new Rooms();

            // assign this room to location 1,0
            rooms[2, 2] = room;

            //Room proerties.
            room.RoomTitle = "Murky Lake";
            room.RoomDescription = "You have arrived at a Murky Lake. Upon closer inspection you recoil - there is something moving down there!";

            // add an exit using the method, then assign direction.
            room.AddExit(Direction.North); // direction = 1,2
            room.AddExit(Direction.West); // direction = 2,1
            room.AddExit(Direction.South); //direction = 3,2


            #endregion

            #region denser forest 3,0
            //new room
            room = new Rooms();

            // assign this room to location 1,0
            rooms[3, 0] = room;

            //Room proerties.
            room.RoomTitle = "Denser Forest";
            room.RoomDescription = "This forest is so thick it is impassable.";

            // add an exit using the method, then assign direction.
            room.AddExit(Direction.North); // direction = 2,0
            room.AddExit(Direction.East); //direction = 3,1
            #endregion

            #region blocked forest 3,1
            //new room
            room = new Rooms();

            // assign this room to location 1,0
            rooms[3, 1] = room;

            //Room proerties.
            room.RoomTitle = "Blocked Forest";
            room.RoomDescription = "You have arrived at Blocked Forest. If only you had an Axe to chop through.";

            // add an exit using the method, then assign direction.
            room.AddExit(Direction.North); // direction = 1,0
            room.AddExit(Direction.East); // direction = 2,1



            #endregion

            #region shallow lake 3,2
            //new room
            room = new Rooms();

            // assign this room to location 1,0
            rooms[3, 2] = room;

            //Room proerties.
            room.RoomTitle = "Shallow Lake";
            room.RoomDescription = "You have arrived at a Shallow Lake. You can see the lake bed beneath the pristine water.";

            // add an exit using the method, then assign direction.
            room.AddExit(Direction.North); // direction = 2,2
            room.AddExit(Direction.West); // direction = 3,1



            #endregion

            #region Library 4,0
            //new room
            room = new Rooms();

            // assign this room to location 1,0
            rooms[4, 0] = room;

            //Room proerties.
            room.RoomTitle = "Ballroom";
            room.RoomDescription = "You have entered the Library.";

            // add an exit using the method, then assign direction.
            room.AddExit(Direction.East); // direction = 4,1
            room.AddExit(Direction.South); //direction = 5,0
            #endregion

            #region castle 4,1
            //new room
            room = new Rooms();

            // assign this room to location 1,0
            rooms[4, 1] = room;

            //Room proerties.
            room.RoomTitle = "Castle";
            room.RoomDescription = "You have arrived at the Castle.";

            // add an exit using the method, then assign direction.
            room.AddExit(Direction.North); // direction = 3,1
            room.AddExit(Direction.East); // direction = 4,2
            room.AddExit(Direction.South); //direction = 5,1


            #endregion

            #region dining room 4,2
            //new room
            room = new Rooms();

            // assign this room to location 1,0
            rooms[4, 2] = room;

            //Room proerties.
            room.RoomTitle = "Dining Room";
            room.RoomDescription = "You have arrived in the Dining Room.";

            // add an exit using the method, then assign direction.
            room.AddExit(Direction.West); // direction = 2,1
            room.AddExit(Direction.South); //direction = 3,0


            #endregion

            #region corridor 5,0
            //new room
            room = new Rooms();

            // assign this room to location 1,0
            rooms[5, 0] = room;

            //Room proerties.
            room.RoomTitle = "Corridor";
            room.RoomDescription = "You have arrived in the Corridor, the Red Cap is waiting for you.";

            // add an exit using the method, then assign direction.
            room.AddExit(Direction.North); // direction = 1,0
            room.AddExit(Direction.East); // direction = 2,1
            room.AddExit(Direction.South); //direction = 3,0


            #endregion

            #region entrance hall 5,1
            //new room
            room = new Rooms();

            // assign this room to location 1,0
            rooms[5, 1] = room;

            //Room proerties.
            room.RoomTitle = "Entrance Hall";
            room.RoomDescription = "You have arrived .";

            // add an exit using the method, then assign direction.
            room.AddExit(Direction.North); // direction = 4,1
            room.AddExit(Direction.East); // direction = 5,2
            room.AddExit(Direction.West); //direction = 5,0


            #endregion

            //place the player in the start room
            Player.PosX = 0;
            Player.PosY = 0;
        }
    }
}
