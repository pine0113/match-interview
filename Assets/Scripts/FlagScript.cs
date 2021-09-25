using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlagScript : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {       
        if (collision.gameObject.tag == "Player")
            UIController.restartPanelon = true;
    }


}
