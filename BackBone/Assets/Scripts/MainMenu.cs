using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    const int MAINMENU  = 0;
    const int LEVEL1    = 1;
    const int CREDITS   = 2;

    public void GoToMainMenu()
    {
        SceneManager.LoadScene(MAINMENU);
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(LEVEL1);
    }

    public void ShowCredits()
    {
        SceneManager.LoadScene(CREDITS);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
