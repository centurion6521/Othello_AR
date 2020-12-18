using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameplayManager : MonoBehaviour
{

    public Text Scoretext;
    private int currentScore=0;
    private int GMCC=0;
    public void UpdateScore(int score, int clickcount)
    {
        currentScore += score;
        GMCC += clickcount;
        Scoretext.text = "Score: " + currentScore.ToString();
      // Scoretext.text = "Manche: " + GMCC.ToString();
    }
}
