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
        //Debug.Log(clickcount);
        Scoretext.text = "Score: " + currentScore.ToString();
        if (clickcount == 59)
        {
            if (currentScore < 0) { Scoretext.text = "Victoire des Noirs "; }
            if (currentScore > 0) { Scoretext.text = "Victoire des Blancs "; }
            if (currentScore == 0) { Scoretext.text = "Egalite "; }
        }
      // Scoretext.text = "Manche: " + GMCC.ToString();
    }
}
