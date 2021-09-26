using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIInventory : MonoBehaviour
{

    private Inventory inventory;
    private Transform itemSlotContainer;
    private Transform itemSlotTemplate;

    private void Awake()
    {
        itemSlotContainer = transform.Find("itemSlotContainer");
        itemSlotTemplate = itemSlotContainer.Find("itemSlotTemplate");
       
    }

    public void SetInventory(Inventory inventory){
        this.inventory = inventory;
        RefreshInventoryItems();
    }

    private void RefreshInventoryItems()
    {
        int x = 0;
        int y = 0;
        float itemSlotCellsize = 100f;
        foreach (Item item in inventory.getItemList()) {
            RectTransform itemSlotRectTransform = Instantiate(itemSlotTemplate, itemSlotContainer).GetComponent<RectTransform>();
            itemSlotRectTransform.gameObject.SetActive(true);
            
            itemSlotRectTransform.anchoredPosition = new Vector2( x * itemSlotCellsize -110, + y * itemSlotCellsize - 50);

            (itemSlotRectTransform.Find("image").GetComponent<Image>()).sprite=item.GetSprite();          
            (itemSlotRectTransform.Find("text_count").GetComponent<Text>()).text = item.amount.ToString();
            
            itemSlotRectTransform.GetComponent<Button>().onClick.AddListener(delegate { UIController.OpenDescriptPanel(item); });

            x++;
            if (x > 2)
            {
                x = 0;
                y ++;
            }

         }

    }

   
}
