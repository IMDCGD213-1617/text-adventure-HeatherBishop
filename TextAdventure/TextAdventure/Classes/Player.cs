using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventure
{
   static class Player
    {
        //Variables

        private static int posX;
        private static int posY;

        private static List<Items> inventoryItems;

        private static int numMoves = 0;

        private static int weightCapacity = 4;

        #region properties
        public static int PosX
        {
            get { return posX; }
            set { posX = value; }
        }
        public static int PosY
        {
            get { return posY; }
            set { posY = value; }
        }
        public static int Moves
        {
            get { return numMoves; }
            set { numMoves = value; }
        }

        public static int WeightCapacity
        {
            get { return weightCapacity; }
            set { weightCapacity = value; }
        }

        public static int currentWeight
        {
            get
            {
                int resultWeight = 0; //holds whatever weight value from items
                foreach (Items item in inventoryItems)
                {
                    resultWeight += item.Weight; //add item weight to result weight
                }
                return resultWeight;
                
            } //check inventory, add up what each items weights, return to inventoryWeight
        }



        #endregion

        static Player()
        {   
            inventoryItems = new List<Items>();
        }


        //Move()
        //What direction are you trying to move?
        //Ask room if we can move that direction
        //Advance xy direction accordingly
        //Show new room.
        public static void Move(string direction)
        {
            Rooms room = Player.GetCurrentRoom();
            if (!room.CanExit(direction))
            {
                TextBuffer.Add("Invalid Direction");
                return;
            }

            //have moved, incriment value
            Player.numMoves++;

            //move based on player input direction
            switch(direction)
            {
                case Direction.North:
                posX--; //decriment to move up in grid
                break;

                case Direction.South:
                posX++; //incriment to move down in grid
                break;

                case Direction.East:
                posY++; //incriment to move right in grid
                break;

                case Direction.West:
                posY--; //incriment to move left in grid
                break;
            }

            Player.GetCurrentRoom().DescribeRoom();

            


        }

        //Pick Up Item()
        //Does this item exist?
        //If yes, put it in inventory if all checks are ok.
        public static void PickUpItem(string itemName)
        {
            //what room are we in?
            Rooms room = Player.GetCurrentRoom();

            //Find items in this room
            Items item = room.GetItem(itemName);

            //was there an item?
            if (item != null)
            {
                if (Player.currentWeight + item.Weight > Player.weightCapacity) //check inventory weight
                {
                    TextBuffer.Add("Overencumbered, drop some items and try again.");
                    return;
                }
                //if reach this point, there is enough room in inventory
                room.Items.Remove(item);
                Player.inventoryItems.Add(item);
                TextBuffer.Add(item.ItemDescription);
            }
            else
                TextBuffer.Add("There is no " + itemName + " in this room.");
        }



        //Drop Item()
        //Remove item from inventory
        //Drop in current room item list.
        public static void DropItem(string itemName)
        {
            //get current room, store in variable
            Rooms room = Player.GetCurrentRoom();

            //hold item from within inventory
            Items item = GetInventoryItem(itemName);

            //check for item
            if (item != null) //is item
            {
                Player.inventoryItems.Remove(item);
                room.Items.Add(item); // add item to room
                TextBuffer.Add("The " + itemName + " has been dropped in the room");
            }
            else // no item
                TextBuffer.Add("There is no " + itemName + " in your inventory");
        }


        //Display Inventory()
        //Show inventory and weight left.
        public static void DisplayInventory()
        {
            //strings to hold message
            string message = "You're inventory contains:";
            string items = ""; 
            string underlined = "";
            underlined = underlined.PadLeft(message.Length, '-');

            //if there are no items

            if (inventoryItems.Count > 0) //if greater than 0
            {
                foreach (Items item in inventoryItems)
                {
                    items += "\n[" + item.ItemTitle + "] Wt: " + item.Weight.ToString();
                }
            }
            else
                items = "\n<no items>";

            items += "\n\nTotal Wt: " + Player.currentWeight + " / " + Player.WeightCapacity;

            //send info to text buffer
            TextBuffer.Add(message + "\n" + underlined + items);
        }
        //Get Current Room()
        //So we dont have to always work in coordinates
        public static Rooms GetCurrentRoom()
        {
            return Level.Room[posX, posY];
        }
        //Get Inventory Item()
        //Take in a text name
        //Check if it exists
        public static Items GetInventoryItem(string itemName)
        {
            foreach (Items item in inventoryItems)
            {
                //if name is == to type name
                if (item.ItemTitle.ToLower() == itemName.ToLower())
                    return item;
            }
            //no item matched
            return null;
        }
    }
}
