using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour
{
    public static GameObject backpackPanel;
    public static GameObject descriptPanel;
    public static GameObject restartPanel;

    private void Awake()
    {
    backpackPanel = GameObject.Find("Panel_backpack");
    descriptPanel = GameObject.Find("Panel_descript");
    restartPanel = GameObject.Find("Panel_restart");
    backpackPanel.SetActive(false);
    restartPanel.SetActive(false);
    }

    private void Update()
    {
      

    }

    public static void OpenBackpackPanel()
    {
        
        backpackPanel.SetActive(true);
    }

    public static void CloseBackpckPanel()
    {
        backpackPanel.SetActive(false);
    }

    public static void OpenDescriptPanel(Item item)
    {
        descriptPanel.SetActive(true);
    }

    public static void CloseDescriptPanel()
    {
        descriptPanel.SetActive(false);
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

}
