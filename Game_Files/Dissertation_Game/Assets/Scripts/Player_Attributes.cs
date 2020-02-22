using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Attributes : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void upgradeHealth1()
    {
        PlayerHealth.playerHealthMax = PlayerHealth.playerHealthMax + 100;
    }

    public void upgradeHealth2()
    {
        PlayerHealth.playerHealthMax = PlayerHealth.playerHealthMax + 100;
    }

    public void upgradeHealth3()
    {
        PlayerHealth.playerHealthMax = PlayerHealth.playerHealthMax + 100;
    }

}

