using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{

    private List<Item> itemList;
    public Inventory()
    {

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

        Debug.Log(itemList.FindIndex(i => i.itemType == item.itemType));
        if (item.amount >= 1)
        {
            item.amount--;
            //Debug.Log("after minus:" + item.name + ">" + item.amount);
            //debugItemList(itemList);
        }
        if (item.amount == 0)
        {
            //Debug.Log("before remove:" + item.name + ">" + item.amount);
            //debugItemList(itemList);

            

            itemList.RemoveAt(itemList.FindIndex(i => i.itemType == item.itemType));

            //Debug.Log("after remove:" + item.name + ">" + item.amount);
            //debugItemList(itemList);

            //Destroy(item);
            //debugItemList(itemList);
            UIController.CloseDescriptPanel();
           
        }
        UIController.RefreshDescriptPanel(item);
        FindObjectOfType<DuckMovement>().refreshUI();
    }

    private void debugItemList(List<Item> l)
    {
        Debug.Log("list:");
        foreach (Item i in l)
        {

            Debug.Log("item:" + i.name + "=" + i.amount+",index:"+l);
        }
        Debug.Log("end-list");
    }

}
