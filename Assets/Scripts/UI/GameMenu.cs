using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using IJunior.TypedScenes;

public class GameMenu : MonoBehaviour
{
    private void Start()
    {
        Time.timeScale = 1;
    }

    public void ContinueGame(GameObject panel)
    {
        panel.SetActive(false);
        Time.timeScale = 1;
    }

    public void PauseMenu(GameObject panel)
    {
        panel.SetActive(true);
        Time.timeScale = 0;
    }

    public void BackToMainMenu()
    {
        StartScreen.Load();
    }
}
