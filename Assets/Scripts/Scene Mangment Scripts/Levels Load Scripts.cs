using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelelsLoadScripts : MonoBehaviour
{
    public void Level1Scene()
    {
        SceneManager.LoadScene(1);
    }

    public void Level2Scene()
    {
        SceneManager.LoadScene(2);
    }
}
