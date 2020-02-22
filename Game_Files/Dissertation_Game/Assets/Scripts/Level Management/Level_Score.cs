using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Level_Score : MonoBehaviour
{
    public Text gameScore;
    public int playerScore;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        playerScore = PlayerScore.playerpoints;
        gameScore.text = "Score: " + playerScore;

    }
}
