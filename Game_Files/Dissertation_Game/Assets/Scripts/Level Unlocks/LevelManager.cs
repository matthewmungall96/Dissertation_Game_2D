using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class LevelManager
{
    [Header("Individual Level Checker")]
    public static bool Mars_Level_1 = false;
    public static bool Mars_Level_2 = false;
    public static bool Jupiter_Level_1 = false;
    public static bool Jupiter_Level_2 = false;
    public static bool Mars_Level_1FC = false;
    public static bool Mars_Level_2FC = false;
    public static bool Jupiter_Level_1FC = false;
    public static bool Jupiter_Level_2FC = false;

    [Header("Number of Levels Complete")]
    public static int Mars_Levels_Complete = 0;
    public static int Jupiter_Levels_Complete = 0;

    [Header("Boss Fight Variables")]
    public static bool Mars_Boss_Completed = false;
    public static bool Jupiter_Boss_Completed = false;
    public static bool Mars_Boss_CompletedFC = false;
    public static bool Jupiter_Boss_CompletedFC = false;
}