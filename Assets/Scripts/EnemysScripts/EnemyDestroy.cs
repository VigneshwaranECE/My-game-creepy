using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDestroy : MonoBehaviour
{
    public GameObject heartbroke;
    public float time;
    // Start is called before the first frame update
    void Start()
    {
        heartbroke.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Player")
            {
            //Destroy(collision.gameObject);
            //collision.gameObject.SetActive(false);
              sounds.Playsound("enemydestroyed");
              healthmanager.health -= 1;
              StartCoroutine("overlay");
            }
    }
    IEnumerator overlay()
    {
        heartbroke.gameObject.SetActive(true);
        yield return new WaitForSeconds(time);
        heartbroke.gameObject.SetActive(false);
    }
}
