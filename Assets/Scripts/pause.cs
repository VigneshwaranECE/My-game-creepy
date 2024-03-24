using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pause : MonoBehaviour
{
    public GameObject pausebutton, resumebutton;
    // Start is called before the first frame update
    void Start()
    {
        pausebutton.gameObject.SetActive(true);
        resumebutton.gameObject.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {

    }
    /* public void Pausebutton()
     {
         Time.timeScale = 0;
     }
     public void Resumebutton()
     {
         Time.timeScale = 1;
     }*/

    public void PauseResumeButtons(bool ispause)
    {
        if(ispause)
        {
            Time.timeScale = 0;
            pausebutton.gameObject.SetActive(false);
            resumebutton.gameObject.SetActive(true);
        }
        else
        {
            Time.timeScale = 1;
            pausebutton.gameObject.SetActive(true);
            resumebutton.gameObject.SetActive(false);
        }
    }

}