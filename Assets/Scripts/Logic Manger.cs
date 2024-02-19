using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class LogicManger : MonoBehaviour
{
    public static LogicManger Instanc;
    public int playerScore;
    public TextMeshProUGUI scoreText;
    [ContextMenu("Increace Score")]

    private void Awake()
    {
        if (Instanc != null)
            Debug.LogError($"Duplicate LogicManger!");
        Instanc = this;
    }

    private void OnDestroy()
    {
        Instanc = null;
    }
    public void addScore()
    {
        playerScore = playerScore + 1;
        scoreText.text = playerScore.ToString();
    }
}

