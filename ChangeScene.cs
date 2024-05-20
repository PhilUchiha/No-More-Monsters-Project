using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public AudioSource audioSource;

    public void StartGame(){
        SceneManager.LoadScene("ClickerGameplay");
    }
    public void OpenSettings(){
        SceneManager.LoadScene("Settings");
    }
    public void GoToMainMenu(){
        SceneManager.LoadScene("MainMenu");
    }
    public void QuitGame(){
        Application.Quit();
        audioSource.Play();
    }
}
