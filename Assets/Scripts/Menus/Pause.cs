using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Pause : MonoBehaviour
{
    public GameObject pauseMenu;
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape) & pauseMenu.activeSelf == false)
        {
            pauseMenu.SetActive(true);
        }
        else if(Input.GetKeyDown(KeyCode.Escape) & pauseMenu.activeSelf)
        {
            pauseMenu.SetActive(false);
        }
    }
}
