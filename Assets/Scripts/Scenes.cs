
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenes : MonoBehaviour
{
    public void LoadMenuPrincipal()
    {
        
        SceneManager.LoadScene("MainMenuExp", LoadSceneMode.Single);


    }
    public void PlayGame()
	{
		
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

	}
	public void QuitGame()
	{
		
		Debug.Log("QUIT !");
		Application.Quit();

	}

    public void PreviousScene()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);

    }

    public void NextScene()
	{
		
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

	}

    public void NextScenee(int _indexx)
    {
        SceneManager.LoadScene(_indexx);
    }
    public void Acrophobie()
    {

        SceneManager.LoadScene("AcrophobieEXP", LoadSceneMode.Single);

    }

}
