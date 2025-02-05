using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class healthmanager : MonoBehaviour
{
    public GameObject heart1, heart2, heart3;
    public static int health;
    public GameObject emptyheart1, emptyheart2, emptyheart3;
    // Start is called before the first frame update
    void Start()
    {
        health = 3;
        heart1.gameObject.SetActive(true);
        heart2.gameObject.SetActive(true);
        heart3.gameObject.SetActive(true);
        emptyheart1.gameObject.SetActive(false);
        emptyheart2.gameObject.SetActive(false);
        emptyheart3.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (health > 3)
            health = 3;
        switch(health)
        {
            case 3:
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(true);
                heart3.gameObject.SetActive(true);
                emptyheart1.gameObject.SetActive(false);
                emptyheart2.gameObject.SetActive(false);
                emptyheart3.gameObject.SetActive(false);
                break;
            case 2:
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(true);
                heart3.gameObject.SetActive(false);
                emptyheart1.gameObject.SetActive(false);
                emptyheart2.gameObject.SetActive(false);
                emptyheart3.gameObject.SetActive(true);
                break;
            case 1:
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(false);
                heart3.gameObject.SetActive(false);
                emptyheart1.gameObject.SetActive(false);
                emptyheart2.gameObject.SetActive(true);
                emptyheart3.gameObject.SetActive(true);
                break;
            case 0:
                heart1.gameObject.SetActive(false);
                heart2.gameObject.SetActive(false);
                heart3.gameObject.SetActive(false);
                emptyheart1.gameObject.SetActive(true);
                emptyheart2.gameObject.SetActive(true);
                emptyheart3.gameObject.SetActive(true);
                SceneManager.LoadScene("Gameover");
                //Time.timeScale = 0;
                break;
        }
    }
}
