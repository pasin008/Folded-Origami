using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class btn_controller : MonoBehaviour
{
    public string url = "https://drive.google.com/file/d/1kgzDLgxFYufmRmckmGrz13PNaoUIsLWu/view?usp=sharing";
    public void open()
    {
        Application.OpenURL(url);
    }
    public void MenuScene()
    {
        SceneManager.LoadScene("Menu");
    }
    public void PlayScene()
    {
        SceneManager.LoadScene("Play");
    }
    public void AuthorScene()
    {
        SceneManager.LoadScene("Authors");
    }
    public void Quit()
    {
        Application.Quit();
    }
}
