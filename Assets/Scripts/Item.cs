using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item 
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


    public ItemType itemType;
    public int amount;
    private string name;
    private string descript;
    private Sprite sprite;

    public Item(ItemType itemType)
    {
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
}
