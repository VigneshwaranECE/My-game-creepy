using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sounds : MonoBehaviour
{
    public static AudioClip Jumpsound, coinssound, enemysound, playerhitsound;
    static AudioSource audiosrc;
    // Start is called before the first frame update
    void Start()
    {
        audiosrc = GetComponent<AudioSource>();
        Jumpsound = Resources.Load<AudioClip>("jump");
        coinssound = Resources.Load<AudioClip>("coincollection");
        enemysound = Resources.Load<AudioClip>("Enemydestroy");
        playerhitsound = Resources.Load<AudioClip>("playerhit");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public static void Playsound(string Clip)
    {
        switch(Clip)
        {
            case "jump":
                audiosrc.PlayOneShot(Jumpsound);
                break;
            case "coincollection":
                audiosrc.PlayOneShot(coinssound);
                break;
            case "enemydestroyed":
                audiosrc.PlayOneShot(enemysound);
                break;
            case "playerhit":
                audiosrc.PlayOneShot(playerhitsound);
                break;


        }
    }
}
