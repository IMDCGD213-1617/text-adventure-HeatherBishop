using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventure
{
    class Rooms
    {
        //Variables
        private string roomTitle;

        private string roomDescription;

        private List<string> exits;

        private List<Items> items;

        #region properties  //So can collapse properties for easier reading

        public string RoomTitle
        {
            get { return roomTitle; }
            set { roomTitle = value; }
        }

        public string RoomDescription
        {
            get { return roomDescription; }
            set { roomDescription = value; }
        }
        public List<Items> Items
        {
            get { return items; }
            set { items = value; }
        }
        #endregion

        public Rooms()
        {
            exits = new List<string>();
            items = new List<Items>();
        }


        //Public Methods.
        #region public methods

        //Describe Room()

        public void DescribeRoom()
        {
            TextBuffer.Add(this.GetCoordinates());
            TextBuffer.Add(this.roomDescription);
            TextBuffer.Add(this.GetItemList());
            TextBuffer.Add(this.GetExitList());
        }

        //Show Title()
        public void ShowTitle()
        {
            TextBuffer.Add(this.roomTitle);
        }

        //Get Item()
        //Does this room have items?
        //By matching name.   

        public Items GetItem(string itemName)
        {
            foreach (Items item in this.items)
            {
                //check if item is == itemName
                if (item.ItemTitle.ToLower() == itemName.ToLower())
                    return item;

            }
            return null; // did not find an item matching itemName
        }

        //Add Exit() to room

        public void AddExit(string direction)
        {
            //take direction, if it doesnt exist:
            if (this.exits.IndexOf(direction) == -1)
                //if not add it to list
                this.exits.Add(direction);
        }

        //Remove Exit()
        public void RemoveExit(string direction)
        {
            //take direction, if it does exist:
            if (this.exits.IndexOf(direction) != -1)
                this.exits.Remove(direction);
        }

        //Can Exit()
        //Check if the player can exit in specific direction
        public bool CanExit(string direction)
        {
            //are any exits == to one we're in
            foreach (string validExit in this.exits)
            {
                if (direction == validExit) //if direction same as exit we pulled from exits list
                    return true; 
            }
            //if reach this point, no valid exit found.
            return false;
        }

        #endregion

        //Private Methods
        #region private methods

        //Get Item List()
        //What are the items in this room?
        //Generate Text display for everything in room.
        private string GetItemList()
        {
            //show text items in room
            string itemString = ""; // items that are in room
            string message = "Items in Room:"; //message to player
            string underline = "";
           underline = underline.PadLeft(message.Length, '-'); //underline to make display more pleasing to player

            //go through items, add to list of text
            if (this.items.Count > 0) //if greater than 0
            {
                foreach (Items item in this.items)
                {
                    itemString += "\n[" + item.ItemTitle + "]";
                }
            }
            else
            {
                itemString = "\n<none>"; // no items
            }

            //get string ready for display
            return "\n" + message + "\n" + underline + itemString;
        }


        //Get Exit List()
        private string GetExitList()
        {
            //show text items in room
            string exitString = ""; // exits that are in room
            string message = "Possible Directions:"; //message to player
            string underline = "";
           underline = underline.PadLeft(message.Length, '-');

            //go through items, add to list of text
            if (this.exits.Count > 0) //if greater than 0
            {
                foreach (string exitDirection in this.exits)
                {
                    exitString += "\n[" + exitDirection + "]";
                }
            }
            else
            {
                exitString = "\n<none>"; // no exit
            }

            //get string ready for display
            return "\n" + message + "\n" + underline + exitString;

        }
        //Get Coordinates()
        //For Debug purposes.
        private string GetCoordinates()
        {
            
            //starting rows using y.
            for (int y = 0; y < Level.Room.GetLength(1); y++) 
            {
                //starting columns using x
                for (int x = 0; x < Level.Room.GetLength(0); x++)
                {
                    if (this == Level.Room[x, y])
                    {
                        return "[" + x.ToString() + "," + y.ToString() + "]";
                    }
                }
                
            }
            return "This room is not within the Room grid.";
        }
        #endregion

    }
}
