using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heart : MonoBehaviour
{
    public GameObject heartfull;
    public float time;
    // Start is called before the first frame update
    void Start()
    {
        heartfull.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name =="Player")
        {
            sounds.Playsound("playerhit");
            healthmanager.health += 1;
            StartCoroutine("overlay");
           
        }
    }
    IEnumerator overlay()
    {
        heartfull.gameObject.SetActive(true);
        GetComponent<SpriteRenderer>().enabled = false;
        yield return new WaitForSeconds(time);
        heartfull.gameObject.SetActive(false);
        Destroy(gameObject);
    }
}
