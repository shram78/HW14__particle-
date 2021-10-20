using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using IJunior.TypedScenes;

public class MainMenu : MonoBehaviour
{
    public void StartGame()
    {
        Game.Load();
    }

    public void AboutAuthors(GameObject panel)
    {
        panel.SetActive(true);
    }

    public void BackToMainMenu(GameObject panel)
    {
        panel.SetActive(false);
    }

    public void Exit()
    {
        Debug.Log("Сработала кнопка выйти из игры");
        Application.Quit();
    }
}
