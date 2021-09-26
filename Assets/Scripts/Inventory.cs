using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{

    private List<Item> itemList;
    public Inventory() {

        itemList = new List<Item>();

        addItem(new Item(Item.ItemType.blackChoco) { amount = 2 });
        addItem(new Item(Item.ItemType.redPotion) { amount = 3 });
        addItem(new Item(Item.ItemType.orangePotion) { amount = 7 });
        addItem(new Item(Item.ItemType.yellowPotion) { amount = 1 });
        addItem(new Item(Item.ItemType.greenPotion) { amount = 4 });
        addItem(new Item(Item.ItemType.bluePotion) { amount = 5 }); 


        Debug.Log(itemList.Count);
    }

    public void addItem(Item item)
    {
        itemList.Add(item);
    }

    public List<Item> getItemList()
    {
        return itemList;
    }

    public void useItem(Item item)
    {
        if (item.amount > 0)
        {
            item.amount--;

            if (item.amount == 0)
            {
                UIController.CloseDescriptPanel();
            }

        }
    }

}
