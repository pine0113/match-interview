using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIHandler : MonoBehaviour
{
    public GameObject backpackPanel;
    public GameObject descriptPanel;

    public void OpenBackpackPanel()
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

}
