using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneController : MonoBehaviour
{
    //private Animator anim;

    public void ResetScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        //anim = GameObject.Find("duck").GetComponent<Animator>();
        //anim.Play("Idel", -1, 0f);
    }
}
