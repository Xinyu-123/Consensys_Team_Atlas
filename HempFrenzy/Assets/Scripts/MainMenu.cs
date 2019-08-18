using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayStory()
    {
        SceneManager.LoadScene("Level1");
    }

    public void PlayInfinite()
    {
        SceneManager.LoadScene("InfiniteMode");
    }

    public void Exit() {
        Application.Quit();
    }

    public void Rules()
    {
        Debug.Log("Press Space to Jump. Collect Coins");
    }
    

}
