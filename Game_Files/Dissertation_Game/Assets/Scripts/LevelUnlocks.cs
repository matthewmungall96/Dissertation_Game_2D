using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelUnlocks : MonoBehaviour
{
    [Header("Buttons for Jupiter and Venus Unlocked")]
    public GameObject Jupiter_Button;
    public GameObject Venus_Button;
    [Header("Number of Levels Complete")]
    public static int Mars_Levels_Complete = 0;
    public static int Jupiter_Levels_Complete = 0;
    public static int Venus_Levels_Complete = 0;
    [Header("Mars Ticks and Crosses")]
    public GameObject MarsC1;
    public GameObject MarsT1;
    public GameObject MarsC2;
    public GameObject MarsT2;
    public GameObject MarsC3;
    public GameObject MarsT3;
    [Header("Jupiter Ticks and Crosses")]
    public GameObject JupiterC1;
    public GameObject JupiterT1;
    public GameObject JupiterC2;
    public GameObject JupiterT2;
    public GameObject JupiterC3;
    public GameObject JupiterT3;
    [Header("Venus Ticks and Crosses")]
    public GameObject VenusC1;
    public GameObject VenusT1;
    public GameObject VenusC2;
    public GameObject VenusT2;
    public GameObject VenusC3;
    public GameObject VenusT3;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Mars_Levels_Complete == 3)
        {
            All_Mars_Complete();
        }

        if (Jupiter_Levels_Complete == 3)
        {
            All_Jupiter_Complete();
        }
        
    }

    public void Mars_1_Complete()
    {
        MarsC1.SetActive(false);
        MarsT1.SetActive(true);
        if (Mars_Levels_Complete == 3)
        {
            return;
        }
        else
        {
            Mars_Levels_Complete++;
        }
    }

    public void Mars_2_Complete()
    {
        MarsC2.SetActive(false);
        MarsT2.SetActive(true);
        if (Mars_Levels_Complete == 3)
        {
            return;
        }
        else
        {
            Mars_Levels_Complete++;
        }
    }

    public void Mars_3_Complete()
    {
        MarsC3.SetActive(false);
        MarsT3.SetActive(true);
        if (Mars_Levels_Complete == 3)
        {
            return;
        }
        else
        {
            Mars_Levels_Complete++;
        }
    }

    public void All_Mars_Complete()
    {
        Jupiter_Button.SetActive(true);
    }

    public void Jupiter_1_Complete()
    {
        JupiterC1.SetActive(false);
        JupiterT1.SetActive(true);
        if (Jupiter_Levels_Complete == 3)
        {
            return;
        }
        else
        {
            Jupiter_Levels_Complete++;
        }
    }
    public void Jupiter_2_Complete()
    {
        JupiterC2.SetActive(false);
        JupiterT2.SetActive(true);
        if (Jupiter_Levels_Complete == 3)
        {
            return;
        }
        else
        {
            Jupiter_Levels_Complete++;
        }
    }
    public void Jupiter_3_Complete()
    {
        JupiterC3.SetActive(false);
        JupiterT3.SetActive(true);
        if (Jupiter_Levels_Complete == 3)
        {
            return;
        }
        else
        {
            Jupiter_Levels_Complete++;
        }
    }

    public void All_Jupiter_Complete()
    {
        Venus_Button.SetActive(true);
    }

    public void Venus_1_Complete()
    {
        VenusC1.SetActive(false);
        VenusT1.SetActive(true);
        if (Venus_Levels_Complete == 3)
        {
            return;
        }
        else
        {
            Venus_Levels_Complete++;
        }
    }
    public void Venus_2_Complete()
    {
        VenusC2.SetActive(false);
        VenusT2.SetActive(true);
        if (Venus_Levels_Complete == 3)
        {
            return;
        }
        else
        {
            Venus_Levels_Complete++;
        }
    }
    public void Venus_3_Complete()
    {
        VenusC3.SetActive(false);
        VenusT3.SetActive(true);
        if (Venus_Levels_Complete == 3)
        {
            return;
        }
        else
        {
            Venus_Levels_Complete++;
        }
    }

    public void Add_One_Level()
    {
        if (Mars_Levels_Complete == 3)
        {
            return;
        }
        else
        {
            Mars_Levels_Complete++;
        }

        Debug.Log("Mars Levels Complete " + Mars_Levels_Complete);
    }
}
