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
        bool match = false;
        foreach (Item i in itemList)
        {
            
            if (i.itemType == item.itemType)
            {
                match = true;
                i.amount += item.amount;
            }
            
        }
        if (!match) { 
            itemList.Add(item);
        }
        //FindObjectOfType<UIInventory>().RefreshInventoryItems();

        Debug.Log(itemList.Count);
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
            UIController.RefreshDescriptPanel(item);

            if (item.amount == 0)
            {
                itemList.Remove(item);
                //Destroy(item);
                UIController.CloseDescriptPanel();
            }

        }
    }

}
