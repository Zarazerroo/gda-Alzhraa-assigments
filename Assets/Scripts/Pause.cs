using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Pause : MonoBehaviour
{
    public void OnClick()
    {
        PauseGame();
    }

    public void PauseGame()
    {
        Time.timeScale = 0;
    }
}
