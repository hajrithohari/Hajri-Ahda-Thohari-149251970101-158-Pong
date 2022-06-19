using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
   public void PlayGame()
    {
        SceneManager.LoadScene("Game");
        Debug.Log("Created by Hajri Ahda Thohari - 149251970101-158");
    }

    public void BackToMainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void Credit()
    {
        SceneManager.LoadScene("Credit");
    }
}
