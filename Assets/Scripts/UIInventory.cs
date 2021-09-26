using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIInventory : MonoBehaviour
{

    private Inventory inventory;
    private Transform itemSlotContainer;
    private Transform itemSlotTemplate;
    private Item selectedItem;

    private void Awake()
    {
        selectedItem = null;
        itemSlotContainer = transform.Find("itemSlotContainer");
        itemSlotTemplate = itemSlotContainer.Find("itemSlotTemplate");
       
    }

    private void Update()
    {
        if (selectedItem != null) {
            UIController.RefreshDescriptPanel(selectedItem);            
        }
       
    }

    public void SetInventory(Inventory inventory){
        Debug.Log("enter SetInventory" + inventory.getItemList().Count);
        this.inventory = inventory;
        RefreshInventoryItems();
    }



    public void RefreshInventoryItems()
    {
        itemSlotContainer = transform.Find("itemSlotContainer");
        itemSlotTemplate = itemSlotContainer.Find("itemSlotTemplate");

        Debug.Log(" enter RefreshInventoryItems" + (inventory.getItemList()).Count);
        int x = 0;
        int y = 0;
        float itemSlotCellsize = 100f;
        foreach (Item item in inventory.getItemList()) {
            Debug.Log("add:" + item.name + "UI");
            RectTransform itemSlotRectTransform = Instantiate(itemSlotTemplate, itemSlotContainer).GetComponent<RectTransform>();
            itemSlotRectTransform.gameObject.SetActive(true);
            
            itemSlotRectTransform.anchoredPosition = new Vector2( x * itemSlotCellsize,  - y * itemSlotCellsize);

            (itemSlotRectTransform.Find("image").GetComponent<Image>()).sprite=item.GetSprite();          
            (itemSlotRectTransform.Find("text_count").GetComponent<Text>()).text = item.amount.ToString();
            
            itemSlotRectTransform.GetComponent<Button>().onClick.AddListener(delegate { selectedItem = item; UIController.OpenDescriptPanel(item,inventory); });

            x++;
            if (x > 2)
            {
                x = 0;
                y ++;
            }

        }
        
    }

    

   
}
