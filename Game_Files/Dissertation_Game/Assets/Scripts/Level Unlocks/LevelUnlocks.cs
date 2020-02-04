using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelUnlocks : MonoBehaviour
{
    [Header("Buttons for Mars Levels")]
    public GameObject Mars_Button2;
    [Header("Buttons for Jupiter Levels")]
    public GameObject Jupiter_Button2;
    [Header("Buttons for Venus Levels")]
    public GameObject Venus_Button2;
    [Header("Buttons for Jupiter and Venus Unlocked")]
    public GameObject Jupiter_Button;
    public GameObject Venus_Button;
    [Header("Boss Fight Buttons")]
    public GameObject Mars_Boss_Button;
    public GameObject Jupiter_Boss_Button;
    public GameObject Venus_Boss_Button;
    [Header("Mars Ticks and Crosses")]
    public GameObject MarsC1;
    public GameObject MarsT1;
    public GameObject MarsC2;
    public GameObject MarsT2;
    public GameObject MarsBT;
    public GameObject MarsBC;
    [Header("Jupiter Ticks and Crosses")]
    public GameObject JupiterC1;
    public GameObject JupiterT1;
    public GameObject JupiterC2;
    public GameObject JupiterT2;
    public GameObject JupiterBT;
    public GameObject JupiterBC;
    [Header("Venus Ticks and Crosses")]
    public GameObject VenusC1;
    public GameObject VenusT1;
    public GameObject VenusC2;
    public GameObject VenusT2;
    public GameObject VenusBT;
    public GameObject VenusBC;

    // Update is called once per frame
    void Update()
    {
        if (LevelManager.Mars_Level_1 == true)
        {
            Mars_1_Complete();
        }

        if (LevelManager.Mars_Level_2 == true)
        {
            Mars_2_Complete();
        }

        if (LevelManager.Jupiter_Level_1 == true)
        {
            Jupiter_1_Complete();
        }

        if (LevelManager.Jupiter_Level_2 == true)
        {
            Jupiter_2_Complete();
        }

        if (LevelManager.Venus_Level_1 == true)
        {
            Venus_1_Complete();
        }

        if (LevelManager.Venus_Level_2 == true)
        {
            Venus_2_Complete();
        }

        if (LevelManager.Mars_Boss_Completed == true)
        {
            All_Mars_Complete();
        }

        if (LevelManager.Jupiter_Boss_Completed == true)
        {
            All_Jupiter_Complete();
        }
    }

    public void Mars_1_Complete()
    {
        Mars_Button2.SetActive(true);
        MarsC2.SetActive(true);
        MarsC1.SetActive(false);
        MarsT1.SetActive(true);
        if (LevelManager.Mars_Levels_Complete == 3)
        {
            return;
        }
        else
        {
            LevelManager.Mars_Levels_Complete++;
        }
    }

    public void Mars_2_Complete()
    {
        Mars_Boss_Button.SetActive(true);
        MarsBC.SetActive(true);
        MarsC2.SetActive(false);
        MarsT2.SetActive(true);
        if (LevelManager.Mars_Levels_Complete == 3)
        {
            return;
        }
        else
        {
            LevelManager.Mars_Levels_Complete++;
        }
    }

    public void Mars_Boss_Complete()
    {
        LevelManager.Mars_Boss_Completed = true;
        MarsBC.SetActive(false);
        MarsBT.SetActive(true);
    }

    public void All_Mars_Complete()
    {
        Jupiter_Button.SetActive(true);
    }

    public void Jupiter_1_Complete()
    {
        Jupiter_Button2.SetActive(true);
        JupiterC2.SetActive(true);
        JupiterC1.SetActive(false);
        JupiterT1.SetActive(true);
        if (LevelManager.Jupiter_Levels_Complete == 3)
        {
            return;
        }
        else
        {
            LevelManager.Jupiter_Levels_Complete++;
        }
    }
    public void Jupiter_2_Complete()
    {
        Jupiter_Boss_Button.SetActive(true);
        JupiterBC.SetActive(true);
        JupiterC2.SetActive(false);
        JupiterT2.SetActive(true);
        if (LevelManager.Jupiter_Levels_Complete == 3)
        {
            return;
        }
        else
        {
            LevelManager.Jupiter_Levels_Complete++;
        }
    }
    public void Jupiter_Boss_Complete()
    {
        LevelManager.Jupiter_Boss_Completed = true;
        JupiterBC.SetActive(false);
        JupiterBT.SetActive(true);
    }


    public void All_Jupiter_Complete()
    {
        Venus_Button.SetActive(true);
    }

    public void Venus_1_Complete()
    {

        VenusC1.SetActive(false);
        VenusT1.SetActive(true);
        if (LevelManager.Venus_Levels_Complete == 3)
        {
            return;
        }
        else
        {
            LevelManager.Venus_Levels_Complete++;
        }
    }
    public void Venus_2_Complete()
    {
        VenusBC.SetActive(true);
        VenusC2.SetActive(false);
        VenusT2.SetActive(true);
        if (LevelManager.Venus_Levels_Complete == 3)
        {
            return;
        }
        else
        {
            LevelManager.Venus_Levels_Complete++;
        }
    }
    public void Venus_Boss_Complete()
    {
        LevelManager.Venus_Boss_Completed = true;
        VenusBC.SetActive(false);
        VenusBT.SetActive(true);
    }
}
