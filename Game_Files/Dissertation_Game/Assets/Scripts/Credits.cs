using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Credits : MonoBehaviour
{
    public bool applicationTurnoff;

    // Update is called once per frame
    void Update()
    {
        if (applicationTurnoff == true)
        {
            quitGame();
        }
    }

    public void quitGame()
    {
        Application.Quit();
    }
}
