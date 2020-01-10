using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuConsole : MonoBehaviour
{
    public void IntialStartSelect()
    {
        Debug.Log("0. Intial Entry Success.");
    }

    public void StartGameSelect()
    {
        Debug.Log("1. Game Difficulty Choice Success.");
    }

    public void OptionSelect()
    {
        Debug.Log("2. Game Options Success.");
    }

    public void ExitGameSelect()
    {
        Debug.Log("3. Game Exit Success.");
        Application.Quit();
    }
}
