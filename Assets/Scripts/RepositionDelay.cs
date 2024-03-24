using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RepositionDelay : MonoBehaviour
{
    public float repositiondelay;
    public Movementplayer moveplayer;
    public int score=0;
    public Text ScoreText;
    public Text WinText;
    // Start is called before the first frame update
    void Start()
    {
        moveplayer = FindObjectOfType<Movementplayer>();//Automatically adds the Script in Inspector window
        score = 0;
        ScoreText.text = "Score: " + score;
        WinText.text = " ";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Delay()// user defined functions
    {
        StartCoroutine("ReposCorountine");
    }

    public IEnumerator ReposCorountine()
    {
        yield return new WaitForSeconds(repositiondelay);
        moveplayer.gameObject.SetActive(false);
        moveplayer.transform.position = moveplayer.Reposition;
        moveplayer.gameObject.SetActive(true);
    }

    public void AddScore(int noofcoins)
    {
        //score++;//Score = score +1;
        score += noofcoins;
        sounds.Playsound("coincollection");
        ScoreText.text = "Score: " + score; 
        if(score==14)
        {
            WinText.text = "You Win!!!";
            Time.timeScale = 0;
        }
    }
}
