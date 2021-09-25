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
        key
    }


    public ItemType itemType;
    public int amount;
    public Sprite GetSprite()
    {
        switch (itemType)
        {
            default:
            case ItemType.whiteChoco:   return ItemAssets.Instance.whiteChocoSprite;
            case ItemType.blackChoco:   return ItemAssets.Instance.blackChocoSprite;
            case ItemType.whitePotion:  return ItemAssets.Instance.whitePotionSprite;
            case ItemType.redPotion:    return ItemAssets.Instance.redPotionSprite;
            case ItemType.orangePotion: return ItemAssets.Instance.orangePotionSprite;
            case ItemType.yellowPotion: return ItemAssets.Instance.yellowPotionSprite;
            case ItemType.greenPotion:   return ItemAssets.Instance.greenPotionSprite;
            case ItemType.bluePotion:   return ItemAssets.Instance.bluePotionSprite;
            case ItemType.key:          return ItemAssets.Instance.keySprite;
        }
        
    }

    public string GetName()
    {
        switch (itemType)
        {
            default:
            case ItemType.whiteChoco: return "白巧克力";
            case ItemType.blackChoco: return "黑巧克力";
            case ItemType.whitePotion: return "白色藥水";
            case ItemType.redPotion: return "紅色藥水";
            case ItemType.orangePotion: return "橙色藥水";
            case ItemType.yellowPotion: return "黃色藥水";
            case ItemType.greenPotion: return "綠色藥水";
            case ItemType.bluePotion: return "藍色藥水";
            case ItemType.key: return "鑰匙";
        }
    }

    public string GetDescript()
    {
        switch (itemType)
        {
            default:
            case ItemType.whiteChoco:   return "一包已打開的白色巧克力，到期日被劃掉";
            case ItemType.blackChoco:   return "一包已打開的黑色巧克力，到期日被劃掉";
            case ItemType.whitePotion:  return "不斷冒泡的不知名白色藥水，未封蓋";
            case ItemType.redPotion:    return "不斷冒泡的不知名紅色藥水，未封蓋";
            case ItemType.orangePotion: return "不斷冒泡的不知名橙色藥水，未封蓋";
            case ItemType.yellowPotion: return "不斷冒泡的不知名黃色藥水，未封蓋";
            case ItemType.greenPotion:  return "不斷冒泡的不知名綠色藥水，未封蓋";
            case ItemType.bluePotion:   return "不斷冒泡的不知名藍色藥水，未封蓋";
            case ItemType.key:          return "疑似有防盜芯片的鑰匙";
        }
    }
}
