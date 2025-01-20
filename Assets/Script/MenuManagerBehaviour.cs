using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManagerBehaviour : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("Game"); // Charge la scène "Game"
    }

    public void QuitGame()
    {
        Application.Quit(); // Pour quitter le programme
    }
}
