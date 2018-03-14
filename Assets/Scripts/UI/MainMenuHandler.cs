using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuHandler : MonoBehaviour
{
    public void PlayButton()
    {
        // Debug.Log("Play Button Clicked");
        SceneManager.LoadScene("Week6_2");
    }

    public void ExitButton()
    {
        Application.Quit(); // Quits your game.
    }
}
