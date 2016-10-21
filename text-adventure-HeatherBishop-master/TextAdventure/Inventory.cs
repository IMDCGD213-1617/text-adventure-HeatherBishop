using System;

public class Inventory
{
    public int slotsX = 5, slotsY = 5; // 5x5 grid inventory
    public List<Item> inventory = new List<Item>();

    public


   void Start()
    {
        //Set slots to Empty
        for (int s = 0; s < slotsX * slotsY; s++)
        {
            inventory.Add(new Item());
        }

        //Get Scripts
        dataBase = GameObject.FindGameObjectWithTag("Game Manager").GetComponent<ItemDataBase>();

        //Add Items For Testing
        AddItem(0);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            AddItem(0);

        if (Input.GetKeyDown(KeyCode.R))
            RemoveItem(0);
    }

    void AddItem(int id)//With stacking the currentStack count is being added to all of the items of the same id, and more items still fill the inv.
    {
        for (int i = 0; i < inventory.Count; i++)
        {
            if (inventory[i].itemStack && inventory[i].itemID == id && inventory[i].itemCurrentStack < inventory[i].itemMaxStack)//Stacking
            {
                inventory[i].itemCurrentStack++;//This makes the actual item have a higher current stack
                break;
            }
            else if (inventory[i].itemName == null)
            {
                for (int d = 0; d < dataBase.items.Count; d++)
                {
                    if (dataBase.items[d].itemID == id)
                    {
                        inventory[i] = dataBase.items[d];
                        break;
                    }
                }
                break;
            }
        }
    }

    void RemoveItem(int id)
    {
        for (int i = 0; i < inventory.Count; i++)
        {
            if (inventory[i].itemID == id && inventory[i].itemCurrentStack > 1)
            {
                inventory[i].itemCurrentStack--;
                break;
            }
            else if (inventory[i].itemID == id)
            {
                inventory[i] = new Item();
                break;
            }
        }
    }
}
