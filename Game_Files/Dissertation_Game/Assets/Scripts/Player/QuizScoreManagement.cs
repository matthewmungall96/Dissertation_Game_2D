using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizScoreManagement : MonoBehaviour
{
    public void subBossQuestionCorrect()
    {
        PlayerScore.playerpoints = PlayerScore.playerpoints + 30;
    }

    public void finalBossQuestionCorrect()
    {
        PlayerScore.playerpoints = PlayerScore.playerpoints + 50;
    }

    public void allQuestionsCorrect()
    {
        PlayerScore.playerpoints = PlayerScore.playerpoints + 50;
    }

    public void majorityQuestionsCorrect()
    {
        PlayerScore.playerpoints = PlayerScore.playerpoints + 40;
    }
}
