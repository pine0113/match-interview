using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour
{
    public GameObject backpackPanel;
    public GameObject descriptPanel;
    public GameObject restartPanel;
    public static bool restartPanelon;

    private void Awake()
    {
        backpackPanel.SetActive(false);
        restartPanel.SetActive(false);
    }

    private void Update()
    {
        if (restartPanelon)
        {
            OpenRestartPanel();
        }
        else
        {
            CloseRestartPanel();
           
        }

    }

    public  void OpenBackpackPanel()
    {
        backpackPanel.SetActive(true);
    }

    public void CloseBackpckPanel()
    {
        backpackPanel.SetActive(false);
    }

    public void OpenDescriptPanel()
    {
        descriptPanel.SetActive(true);
    }

    public void CloseDescriptPanel()
    {
        descriptPanel.SetActive(false);
    }

    public void OpenRestartPanel()
    {
        restartPanel.SetActive(true);
        DuckMovement.PlayerControlsDisabled = true;
    }

    public void CloseRestartPanel()
    {     
        restartPanel.SetActive(false);
        DuckMovement.PlayerControlsDisabled = false;        

    }

}
