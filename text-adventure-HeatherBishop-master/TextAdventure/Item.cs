using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventure
{    
	public class Item
	{
        //base class for all items.

        //contains the name
        public string itemName;
        public int itemID;
        //description
        public string itemDescription;
        //value
        public int itemRarity;

            public virtual void Upgrade()
        {
            Console.WriteLine("Upgrade Item.");
        }

        public Item(string name, int id,string description, int rarity)
        {
            itemName = name;
            itemID = id;

            itemDescription = description;
            itemRarity = rarity;
        }

        public Item()
        {
            itemID = -1;
        }

	}



    public class ItemDatabase
    {
        public List<Item> items = new List<Item>();

        void Start()
        {
            items.Add(new Item("Test Item", 0, "You have found a sword", 3));
        }
    }
}
