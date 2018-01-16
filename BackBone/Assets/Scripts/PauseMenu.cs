using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {

    public bool IsPaused { get; set; }

    private void Start()
    {
        IsPaused = false;
        gameObject.SetActive(IsPaused);
    }

    public void PauseGame()
    {
        IsPaused = true;
        gameObject.SetActive(IsPaused);
    }

    public void ResumeGame()
    {
        IsPaused = false;
        gameObject.SetActive(IsPaused);
    }

    public void ExitGame()
    {
        Application.Quit();
    }

}
