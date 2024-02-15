using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class LogicManger : MonoBehaviour
{
    public int playerScore;
    public TextMeshProUGUI scoreText;
    [ContextMenu("Increace Score")]
    public void addScore()
    {
        playerScore = playerScore + 1;
        scoreText.text = playerScore.ToString();
    }
}

