using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resume : MonoBehaviour
{

    public void OnClick()
    {
        ResumeGame();
    }

    public void ResumeGame()
    {
        Time.timeScale = 1;
    }
}
