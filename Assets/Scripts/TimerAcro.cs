using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimerAcro : MonoBehaviour
{
    float currentTime = 0f;
    float startingTime = 80f;
    public Animator m_Animator;
    
    //public AudioSource hotAirBallon;
    

    [SerializeField] Text countDownText;


    // Use this for initialization
    void Start()
    {

        //hotAirBallon = gameObject.GetComponent<AudioSource>();
        m_Animator = gameObject.GetComponent<Animator>();
        Debug.Log(m_Animator);
        currentTime = startingTime;
    }

    // Update is called once per frame
    void Update()
    {
        

        currentTime -= 1 * Time.deltaTime;
        countDownText.text = currentTime.ToString("00:00");

        if (currentTime <= 60.00f )
        {
            
            //hotAirBallon.Play();
            countDownText.color = Color.yellow;
            m_Animator.SetTrigger("up");
            Debug.Log("up2");
        }

        if (currentTime <= 40.00f)
        {
            countDownText.color = Color.green;
            m_Animator.SetTrigger("up1");
            Debug.Log("up2");
        }

        if (currentTime <= 20.00f)
        {
            countDownText.color = Color.red;
            m_Animator.SetTrigger("up2");
            Debug.Log("up2");
        }


        if (currentTime <= 0)
        {
            Time.timeScale = 1f;
            SceneManager.LoadScene("MainMenuExp",LoadSceneMode.Single);

        }
    }

   
}
