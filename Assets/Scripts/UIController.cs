using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public static GameObject backpackPanel;
    public static GameObject descriptPanel;
    public static GameObject restartPanel;
    private static GameObject backpackPanel_back;
    private static GameObject descriptPanel_back;

    private void Awake()
    {
        backpackPanel = GameObject.Find("Panel_backpack");
        backpackPanel_back = GameObject.Find("Back-backpack");
        descriptPanel = GameObject.Find("Panel_descript");
        descriptPanel_back = GameObject.Find("Back-descript");
        restartPanel = GameObject.Find("Panel_restart");
        backpackPanel.SetActive(false);
        restartPanel.SetActive(false);
        descriptPanel.SetActive(false);
    }

    private void Update()
    {
      

    }

    public static void OpenBackpackPanel()
    {
        CloseDescriptPanel();
        backpackPanel_back.SetActive(true);
        backpackPanel.SetActive(true);
    }

    public static void CloseBackpckPanel()
    {

        CloseDescriptPanel();
        backpackPanel.SetActive(false);
        backpackPanel_back.SetActive(false);

    }

    public static void OpenDescriptPanel(Item item)
    {
        backpackPanel_back.SetActive(false);
        descriptPanel_back.SetActive(true);
        Debug.Log("open des panel");
        descriptPanel.SetActive(true);

        RefreshDescriptPanel(item);
        (descriptPanel.transform.Find("Button_UseItem").GetComponent<Button>()).onClick.RemoveAllListeners();
        (descriptPanel.transform.Find("Button_UseItem").GetComponent<Button>()).onClick.AddListener(delegate { FindObjectOfType<DuckMovement>().useItem(item); });

        (descriptPanel.transform.Find("Button_UseItem").GetComponent<ButtonLongPressListener>()).onLongPress.RemoveAllListeners();
        (descriptPanel.transform.Find("Button_UseItem").GetComponent<ButtonLongPressListener>()).onLongPress.AddListener(delegate { FindObjectOfType<DuckMovement>().useItem(item);});

    }


    public static void CloseDescriptPanel()
    {
        descriptPanel.SetActive(false);
        descriptPanel_back.SetActive(false);
        backpackPanel_back.SetActive(true);
    }

    public static void OpenRestartPanel()
    {
        restartPanel.SetActive(true);
        DuckMovement.PlayerControlsDisabled = true;
        GameObject d = GameObject.Find("duck");
        d.transform.position.Set(d.transform.position.x + 20, d.transform.position.y, d.transform.position.z);
    }

    public static void CloseRestartPanel()
    {     
        restartPanel.SetActive(false);
        DuckMovement.PlayerControlsDisabled = false;       

    }

    public static void RefreshDescriptPanel(Item item)
    {
       
        descriptPanel.transform.Find("item_image").GetComponent<Image>().sprite = item.GetSprite();
        descriptPanel.transform.Find("item_count").GetComponent<Text>().text = item.amount.ToString();
        descriptPanel.transform.Find("item_name").GetComponent<Text>().text = item.GetName();
        descriptPanel.transform.Find("item_descript").GetComponent<Text>().text = item.GetDescript();
    }
}
