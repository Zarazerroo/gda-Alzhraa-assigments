using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class LogicManger : MonoBehaviour
{
    public int playerScore;
    public TextMeshProUGUI scoreText;

    public static LogicManger Instance { get; private set; }


    private void Awake()         ///this is the manual way to creat single tone
    {
        if (Instance != null)
            Debug.LogError($"Duplicate LogicManger!");
        Instance = this;
    }
    private void OnDestroy()  ///this is the manual way to creat single tone
    {
        Instance = null;
    }

    [ContextMenu("Increace Score")]
    public void addScore()
    {
        playerScore = playerScore + 1;
        scoreText.text = playerScore.ToString();
    }
}

