using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public GameObject startButton;
    public GameObject tutorialButton;
    public GameObject quitButton;
    public GameObject tutorialPanel;

    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void LoadTutorial()
    {
        startButton.active = false;
        tutorialButton.active = false;
        quitButton.active = false;
        tutorialPanel.active = true;
    }

    public void Back()
    {
        startButton.active = true;
        tutorialButton.active = true;
        quitButton.active = true;
        tutorialPanel.active = false;
    }

    public void QuitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
