using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PauseMenu2 : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;
   
    // Update is called once per frame


    public void LoadMenuPrincipal()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenuExp", LoadSceneMode.Single);


    }

    public void LoadMenuPhobieSoc()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("SocialPhobiaMenu", LoadSceneMode.Single);

    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;

    }

    public void Pause()
    {

        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void Update()
    {
        if (OVRInput.Get(OVRInput.Button.Start) == true)
        {

            Pause();      

        }
    }

    public void LoadMenu()
    {

        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenuExp", LoadSceneMode.Single);
        Debug.Log("Loading Menu ...");
    }

    public void QuitGame()
    {

        Debug.Log("Quitting game ...");
        Application.Quit();
    }
}
