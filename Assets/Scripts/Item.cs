using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{

    public  enum ItemType{
        whiteChoco,
        blackChoco,
        whitePotion,
        redPotion,
        orangePotion,
        yellowPotion,
        greenPotion,
        bluePotion,
        key,
        none
    }

    public enum InteractiveType { None,Pickup,Examine}
    public InteractiveType type;


    public ItemType itemType;
    public string name;
    public int amount;
    public string descript;
    public Sprite sprite;

    private void Reset()
    {
        GetComponent<Collider2D>().isTrigger = true;
        gameObject.layer = 10;
    }


    public void Interact()
    {

        switch (type)
        {
            case InteractiveType.None:
                 break;

            case InteractiveType.Pickup:
                FindObjectOfType<DuckMovement>().pickItem(this);
                
                break;

            case InteractiveType.Examine:
                break;
        }
    }


    public Item(ItemType inputItemType)
    {
        itemType = inputItemType;
        switch (itemType)
        {
            default:
            case ItemType.whiteChoco:
                sprite = ItemAssets.Instance.whiteChocoSprite;
                name = "白巧克力";
                descript = "一包已打開的白色巧克力，到期日被劃掉";
                break;
            case ItemType.blackChoco:
                sprite = ItemAssets.Instance.blackChocoSprite;
                name = "黑巧克力";
                descript = "一包已打開的黑色巧克力，到期日被劃掉";
                break;
            case ItemType.whitePotion:
                sprite = ItemAssets.Instance.whitePotionSprite;
                name = "白色藥水";
                descript = "不斷冒泡的不知名白色藥水，未封蓋";
                break;
            case ItemType.redPotion: 
                sprite = ItemAssets.Instance.redPotionSprite;
                name = "紅色藥水";
                descript = "不斷冒泡的不知名紅色藥水，未封蓋";
                break;
            case ItemType.orangePotion:
                sprite = ItemAssets.Instance.orangePotionSprite;
                name = "橙色藥水";
                descript = "不斷冒泡的不知名橙色藥水，未封蓋";
                break;
            case ItemType.yellowPotion:
                sprite = ItemAssets.Instance.yellowPotionSprite;
                name = "黃色藥水";
                descript = "不斷冒泡的不知名黃色藥水，未封蓋";
                break;
            case ItemType.greenPotion:
                sprite = ItemAssets.Instance.greenPotionSprite;
                name = "綠色藥水";
                descript = "不斷冒泡的不知名綠色藥水，未封蓋";
                break;
            case ItemType.bluePotion:
                sprite = ItemAssets.Instance.bluePotionSprite;
                name = "藍色藥水";
                descript = "不斷冒泡的不知名藍色藥水，未封蓋";
                break;
            case ItemType.key:
                sprite = ItemAssets.Instance.keySprite;
                name = "鑰匙";
                descript = "疑似有防盜芯片的鑰匙";
                break;
            case ItemType.none:
                sprite = ItemAssets.Instance.keySprite;
                name = "";
                descript = "";
                break;
        }

    }


    public Sprite GetSprite()
    {
        return sprite;        
    }

    public string GetName()
    {
        return name;
       
    }

    public string GetDescript()
    {
        return descript;        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Player")
        {

            gameObject.SetActive(false);
            FindObjectOfType<DuckMovement>().pickItem(this);
            FindObjectOfType<UIInventory>().RefreshInventoryItems();
        }


    }
}
