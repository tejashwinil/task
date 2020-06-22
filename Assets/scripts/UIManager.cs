using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public void Menu()
    {
        SceneManager.LoadScene("menu");

    }
    public void Scene1()
    {
        SceneManager.LoadScene("cubescene1");

    }
    public void Scene2()
    {
        SceneManager.LoadScene("scene2");

    }
    public void Scene3()
    {
        SceneManager.LoadScene("scene3");

    }
    public void ExitGame()
    {
        Application.Quit();

    }
    public void next1()
    {
        SceneManager.LoadScene("scene2");

    }
}


