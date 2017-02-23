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
            rooms = new Rooms[6, 3]; //x, y

            //temp variables to contain room/item objects.
            Rooms room;
            Items item;



            //create the rooms

            #region Your Office 0,0
            // create new room.
            room = new Rooms();

            // assign this room to location 0,0
            rooms[0, 0] = room;

            //Room proerties.
            room.RoomTitle = "Your Office";
            room.RoomDescription = "You are in your office, the anthropomorphised animal bobble heads bounce obnixiously on your desk.";

            // add an exit using the method, then assign direction.
            room.AddExit(Direction.East); //0,1 LOCATION

            //create new item in this room
            #region item Red Pen
            item = new Items();

            //set up the item
            item.ItemTitle = "Red Pen";
            item.ItemDescription = "You pick up a red pen. George is obsessed with them, he says the colour is more dramatic.";

            //add item to current room
            room.Items.Add(item);

            #endregion


            #endregion

            #region Corridor A 0,1
            //new room
            room = new Rooms();

            // assign this room to location 1,0
            rooms[0, 1] = room;

            //Room proerties.
            room.RoomTitle = "Corridor A";
            room.RoomDescription = "You have entered Corridor A. You can hear George scribbling desperastely to the EAST. You knock on his door and get no response. Perhaps he will open the door if you bring him a gift?";

            // add an exit using the method, then assign direction.
            room.AddExit(Direction.West); // add west direction to return to original location [0,0]            
            room.AddExit(Direction.South); //south direction = 1,1 location



            #endregion

            #region Georges Office 0,2

            //new room
            room = new Rooms();

            // assign this room to location
            rooms[0, 2] = room;

            //Room proerties.
            room.RoomTitle = "Georges' Office";
            room.RoomDescription = "You have entered Georges' Office. He is desperatly rummaging through draws. Sweat glistens on his furrowed brow.";

          

            //create new item in this room
            #region item Stapler
            item = new Items();

            //set up the item
            item.ItemTitle = "Stapler";
            item.ItemDescription = "You pick up a stapler. Like magic, it actually has staples in it.";

            //add item to current room          

            room.Items.Add(item);

            #endregion



            #endregion

            #region Bobs Office 1,0
            //new room
            room = new Rooms();

            // assign this room to location 1,0
            rooms[1, 0] = room;

            //Room proerties.
            room.RoomTitle = "Bobs Office";
            room.RoomDescription = "You have entered Bobs Office. Files are scattered across the room. \nPapers detailing employees working hours and availability are visible on the desk.\n You are pretty sure theres a confidentiality issue there, but he seems to know what hes doing so you let it go.";

            // add an exit using the method, then assign direction.
            
            room.AddExit(Direction.East); // direction = 1,1
            room.AddExit(Direction.South); //direction = 2,0
            

            //create new item
            #region item Basement Key
            item = new Items();

            //set up the item
            item.ItemTitle = "Basement Key";
            item.ItemDescription = "You pick up the Basement Key.";
            item.Weight = 2;

            //add item to current room
            room.Items.Add(item);


            #endregion

            #endregion

            #region Corridor B 1,1
            //new room
            room = new Rooms();

            // assign this room to location 1,0
            rooms[1, 1] = room;

            //Room proerties.
            room.RoomTitle = "Corridor B";
            room.RoomDescription = "You have entered Corridor B. The smell of disinfectant invades your very pores. It seems to be coming from the EAST.";

            // add an exit using the method, then assign direction.
            room.AddExit(Direction.North); // direction = 0,1
            room.AddExit(Direction.East); // direction = 1,1
            room.AddExit(Direction.West); // direction = 1,0
            room.AddExit(Direction.South); //direction = 2,0



            #endregion

            #region Sallys Office 1,2
            //new room
            room = new Rooms();

            // assign this room to location 1,0
            rooms[1,2] = room;

            //Room proerties.
            room.RoomTitle = "Sallys Office";
            room.RoomDescription = "You have entered Sallys Office. Its empty, neatly filed and tidy. Creepy. A bottle of disinfectant stands on her desk, the bin is full of tissue ripe with the same odor.";

            // add an exit using the method, then assign direction.           
            room.AddExit(Direction.West); // west direction = 1,1

            //create new item
            #region item Paper Clip
            item = new Items();

            //set up the item
            item.ItemTitle = "Paper Clip";
            item.ItemDescription = "You pick up the Paper Clip. Yep, that will be useful.";
            item.Weight = 1;

            //add item to current room
            room.Items.Add(item);


            #endregion
            #endregion

            #region Corridor E 2,0
            //new room
            room = new Rooms();

            // assign this room to location 1,0
            rooms[2, 0] = room;

            //Room proerties.
            room.RoomTitle = "Corridor E";
            room.RoomDescription = "You have arrived at a Corridor E. There is an old printer beeping steadily in the corner.";

            // add an exit using the method, then assign direction.
            room.AddExit(Direction.North); // direction = 1,0
            room.AddExit(Direction.East); // direction = 2,1
            room.AddExit(Direction.South); //direction = 3,0


            #endregion

            #region Corridor C 2,1
            //new room
            room = new Rooms();

            // assign this room to location 1,0
            rooms[2, 1] = room;

            //Room proerties.
            room.RoomTitle = "Corridor C";
            room.RoomDescription = "You have arrived at Corridor C. You dodge a suspicious stain on the floor. The smell of food and coffee tempts you to move East.";

            // add an exit using the method, then assign direction.
            room.AddExit(Direction.North); // direction = 1,1
            room.AddExit(Direction.East); // direction = 2,2
            room.AddExit(Direction.South); //direction = 3,1
            room.AddExit(Direction.West); // direction 2,0


            #endregion

            #region Kitchen 2,2
            //new room
            room = new Rooms();

            // assign this room to location 1,0
            rooms[2, 2] = room;

            //Room proerties.
            room.RoomTitle = "Kitchen";
            room.RoomDescription = "You have entered the Kitchen. A fridge, microwave and coffee maker are the only things in here. Someone has rearranged the fridge's magnetic letters to spell ECFEOF. Something about those letters makes you pause for a moment.";

            // add an exit using the method, then assign direction.
            room.AddExit(Direction.North); // direction = 1,2
            room.AddExit(Direction.West); // direction = 2,1
            room.AddExit(Direction.South); //direction = 3,2


            #endregion

            #region Meeting Room 3,0
            //new room
            room = new Rooms();

            // assign this room to location 1,0
            rooms[3, 0] = room;

            //Room proerties.
            room.RoomTitle = "Meeting Room";
            room.RoomDescription = "The Meeting Room is dark and quiet. The faint sobs of young intern's dreams being dashed can be heard if you listen closely enough.";

            // add an exit using the method, then assign direction.
            room.AddExit(Direction.North); // direction = 2,0
            room.AddExit(Direction.East); //direction = 3,1

            //create new item
            #region item Employee Files
            item = new Items();

            //set up the item
            item.ItemTitle = "Employee Files";
            item.ItemDescription = "You pick up the Employee Files. They are heavier than you expected.";
            item.Weight = 1;

            //add item to current room
            room.Items.Add(item);


            #endregion


            #endregion

            #region Common Room 3,1
            //new room
            room = new Rooms();

            // assign this room to location 1,0
            rooms[3, 1] = room;

            //Room proerties.
            room.RoomTitle = "Common Room";
            room.RoomDescription = "You have arrived in the Common Room. Staff gather here to take breaks occasionally.";

            // add an exit using the method, then assign direction.
            room.AddExit(Direction.North); // direction = 1,0
            room.AddExit(Direction.East); // direction = 2,1
            room.AddExit(Direction.West);
            room.AddExit(Direction.South);



            #endregion

            #region Empty Office 3,2
            //new room
            room = new Rooms();

            // assign this room to location 1,0
            rooms[3, 2] = room;

            //Room proerties.
            room.RoomTitle = "Empty Office";
            room.RoomDescription = "You have arrived at the Empty Office. The room is stale from disuse.";

            // add an exit using the method, then assign direction.
            room.AddExit(Direction.North); // direction = 2,2
            room.AddExit(Direction.West); // direction = 3,1



            #endregion

            #region Denises' Office 4,0
            //new room
            room = new Rooms();

            // assign this room to location 1,0
            rooms[4, 0] = room;

            //Room proerties.
            room.RoomTitle = "Denises' Office";
            room.RoomDescription = "You have entered Denise's Office. Nothing of interest jumps out at you. Who exactly is Denise?";

            // add an exit using the method, then assign direction.
            room.AddExit(Direction.East); // direction = 4,1
            room.AddExit(Direction.North);
            #endregion

            #region Corridor F 4,1
            //new room
            room = new Rooms();

            // assign this room to location 1,0
            rooms[4, 1] = room;

            //Room proerties.
            room.RoomTitle = "Corridor F";
            room.RoomDescription = "You have Corridor F. Another uninteresting corridor. You seem quite drawn to repitition.";

            // add an exit using the method, then assign direction.
            room.AddExit(Direction.North); // direction = 3,1
            room.AddExit(Direction.East); // direction = 4,2            
            room.AddExit(Direction.West);

            #endregion

            #region Tims Office 4,2
            //new room
            room = new Rooms();

            // assign this room to location 1,0
            rooms[4, 2] = room;

            //Room proerties.
            room.RoomTitle = "Tims Office";
            room.RoomDescription = "You have arrived in Tims Office. You wonder where he is, shirking his responsibilities. \nWhat, does he think this is some kind of game?";

            // add an exit using the method, then assign direction.
            room.AddExit(Direction.West); // direction = 2,1

           



            #endregion

            #region Boiler Room 5,0
            //new room
            room = new Rooms();

            // assign this room to location 1,0
            rooms[5, 0] = room;

            //Room proerties.
            room.RoomTitle = "Boiler Room";
            room.RoomDescription = "You have arrived in the Boiler Room. The furnace in the corner makes the room unbearably hot.";

            // add an exit using the method, then assign direction.
            
            room.AddExit(Direction.East); // direction = 2,1
            


            #endregion

            #region Basement 5,1
            //new room
            room = new Rooms();

            // assign this room to location 1,0
            rooms[5, 1] = room;

            //Room proerties.
            room.RoomTitle = "Basement";
            room.RoomDescription = "The Basement. You cannot enter without the Basement Key... Or can you?";

            // add an exit using the method, then assign direction.
            room.AddExit(Direction.North); // direction = 4,1
            room.AddExit(Direction.East); // direction = 5,2
            room.AddExit(Direction.West); //direction = 5,0


            #endregion

            #region Storage Room 5,2
            //new room
            room = new Rooms();

            // assign this room to location 1,0
            rooms[5, 2] = room;

            //Room proerties.
            room.RoomTitle = "Storage Room";
            room.RoomDescription = "You have arrived in the Storage Room. Rows of dusty boxes on shelves obstruct your view.";

            // add an exit using the method, then assign direction.                       
            room.AddExit(Direction.West); //direction = 5,0

            //create new item
            #region item Printer Ink
            item = new Items();

            //set up the item
            item.ItemTitle = "Printer Ink";
            item.ItemDescription = "You pick up the Printer Ink.";
            item.Weight = 1;

            //add item to current room
            room.Items.Add(item);


            #endregion

            //create new item
            #region item Manilla Envelope
            item = new Items();

            //set up the item
            item.ItemTitle = "Manilla Envelope";
            item.ItemDescription = "You pick up the Manilla Envelope. Unassuming and useful for sending letters.";
            item.Weight = 2;

            //add item to current room
            room.Items.Add(item);


            #endregion

            #endregion


            //place the player in the start room
            Player.PosX = 0;
            Player.PosY = 0;
        }


        //run this after the player has figured out to type "COFFEE" in the kitchen.
        //So that the kitchen changes and now has the BLACK PEN.
        public static void AmendKitchen()
        {

            //if the player is not in the kitchen
            if (Player.PosX != 2 && Player.PosY != 2)
            {
                
                string message = "This input is invalid. Perhaps you are in the wrong location.";

                TextBuffer.Add(message);
            }


            //if the player is in the kitchen
            if (Player.PosX == 2 && Player.PosY == 2)
            {
                //temp variables to contain room/item objects.
                Rooms room;
                Items item;


                //new room
                room = new Rooms();

                // assign this room to location 1,0
                rooms[2, 2] = room;

                //Room proerties.
 
                room.RoomTitle = "Kitchen";
                room.RoomDescription = "You have entered the Kitchen. A fridge, microwave and coffee maker are the only things in here. The fridge's magnetic letters are arranged to spell COFFEE. The fridge door is now on the jar.";

                // add an exit using the method, then assign direction.
                room.AddExit(Direction.North); // direction = 1,2
                room.AddExit(Direction.West); // direction = 2,1
                room.AddExit(Direction.South); //direction = 3,2

                //add the black pen to the room
                //create new item
                #region item Black Pen
                item = new Items();

                //set up the item
                item.ItemTitle = "Black Pen";
                item.ItemDescription = "You pick up the Black Pen. The preferred pen colour of professionals.";
                item.Weight = 1;

                //add item to current room
                room.Items.Add(item);

                #endregion

            }

        }
    }
}
