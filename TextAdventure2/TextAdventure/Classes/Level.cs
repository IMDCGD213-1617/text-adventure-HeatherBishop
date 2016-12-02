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
            rooms = new Rooms[2, 2]; //2 rooms x, 2 y = 4 rooms total

            //temp variables to contain room/item objects.
            Rooms room;
            Items item;



            //create the rooms

            #region roomOne
            // create new room.
            room = new Rooms();

            // assign this room to location 0,0
            rooms[0, 0] = room;

            //Room proerties.
            room.RoomTitle = "House";
            room.RoomDescription = "You have entered the house.";

            // add an exit using the method, then assign direction.
            room.AddExit(Direction.East);
#endregion

            #region roomTwo
            //new room
            room = new Rooms();

            // assign this room to location 1,0
            rooms[1, 0] = room;

            //Room proerties.
            room.RoomTitle = "Forest";
            room.RoomDescription = "You have entered the Forest.";

            // add an exit using the method, then assign direction.
            room.AddExit(Direction.West); // add west direction to return to original location [0,0]

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

            #region roomThree
            //new room
            room = new Rooms();

            // assign this room to location 1,0
            rooms[1, 1] = room;

            //Room proerties.
            room.RoomTitle = "Forest";
            room.RoomDescription = "You have entered the Forest, there is a castle to the south that is blocked by fallen trees.";

            // add an exit using the method, then assign direction.
            room.AddExit(Direction.North); // add east direction to return to original location [0,0]

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

            #region roomFour
            //new room
            room = new Rooms();

            // assign this room to location 1,0
            rooms[1, 0] = room;

            //Room proerties.
            room.RoomTitle = "Castle";
            room.RoomDescription = "You have entered the Castle.";

            // add an exit using the method, then assign direction.
            room.AddExit(Direction.North); // add east direction to return to original location [0,0]
            

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




            //place the player in the start room
            Player.PosX = 0;
            Player.PosY = 0;
        }
    }
}
