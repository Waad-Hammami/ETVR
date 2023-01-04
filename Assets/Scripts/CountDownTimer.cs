using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountDownTimer : MonoBehaviour {

	float currentTime = 0f;
	float startingTime = 30f ;
	
	
	[SerializeField] Text countDownText;


	// Use this for initialization
	void Start () {
		
		currentTime = startingTime;
	}
	
	// Update is called once per frame
	void Update () {
		
		currentTime -= 1 * Time.deltaTime ;
		countDownText.text = currentTime.ToString("00:00") ;
		
		if(currentTime <= 10.00f)
		{
			
			countDownText.color = Color.red;
		}

		if (currentTime <= 0 )
		{
            Time.timeScale = 1f;
            SceneManager.LoadScene("MainMenuExp", LoadSceneMode.Single);

		}
		
	}

}
