using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu_Open : MonoBehaviour
{
    public GameObject PauseMenu;
    private bool gamePaused = false;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P) && gamePaused == false)
        {
            Paused();
        }

        if (Input.GetKeyDown(KeyCode.P) && gamePaused == true)
        {
            Unpaused();
        }

    }
    
    void Paused()
    {
        Debug.Log("Game Paused");
        Time.timeScale = 0f;
        PauseMenu.SetActive(true);
    }

    public void Unpaused()
    {
        Debug.Log("Game Unpaused");
        Time.timeScale = 1f;
        PauseMenu.SetActive(false);
    }

}
