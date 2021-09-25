using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemAssets : MonoBehaviour
{
  public static ItemAssets Instance { get; private set; }
    private void Awake()
    {
        Instance = this;   
    }

    public Sprite whiteChocoSprite;
    public Sprite blackChocoSprite;
    public Sprite whitePotionSprite;
    public Sprite redPotionSprite;
    public Sprite orangePotionSprite;
    public Sprite yellowPotionSprite;
    public Sprite greenPotionSprite;
    public Sprite bluePotionSprite;
    public Sprite keySprite;
}