using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    public void Play() {
        SceneManager.LoadScene("topdownscene");
    }

    public void Quit() {
        Application.Quit();
        Debug.Log("player has quit the game");
    }
}
