using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.XR;
using UnityEngine.Experimental.XR;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;
    public GameObject LocomotionSys;
    public GameObject LocalAvatar;
    public GameObject RightHand;
    public GameObject LeftHand;

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
        LocomotionSys.SetActive(true);
        LocalAvatar.SetActive(true);
        RightHand.SetActive(false);
        LeftHand.SetActive(false);

    }

    public void Update()
    {
        if (OVRInput.Get(OVRInput.Button.Start) == true)
        {
            pauseMenuUI.SetActive(true);
            Time.timeScale = 0f;
            GameIsPaused = true;
            LocomotionSys.SetActive(false);
            LocalAvatar.SetActive(false);
            RightHand.SetActive(true);
            LeftHand.SetActive(true);
        }
    }

    public void LoadMenu()
    {
       
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
        Debug.Log("Loading Menu ...");
    }

    public void QuitGame()
    {
        
        Debug.Log("Quitting game ...");
        Application.Quit();
    }

    public void SettingMenu()
    {

    }
}
