using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelUnlocker : MonoBehaviour
{
    public void Mars_Level_1()
    {
        LevelManager.Mars_Level_1 = true;
    }
    public void Mars_Level_2()
    {
        LevelManager.Mars_Level_2 = true;
    }
    public void Mars_Level_Boss()
    {
        LevelManager.Mars_Boss_Completed = true;
    }
    public void Jupiter_Level_1()
    {
        LevelManager.Jupiter_Level_1 = true;
    }
    public void Jupiter_Level_2()
    {
        LevelManager.Jupiter_Level_2 = true;
    }
    public void Jupiter_Level_Boss()
    {
        LevelManager.Jupiter_Boss_Completed = true;
    }
}
