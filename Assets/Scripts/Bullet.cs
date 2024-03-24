using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float velx = 5f;
    public float vely = 0f; 
    Rigidbody2D myrb;
    public float velxleft = -5f;
    // Start is called before the first frame update
    void Start()
    {
        myrb = GetComponent<Rigidbody2D>();
        myrb.velocity = new Vector2(velx, vely);
    }

    // Update is called once per frame
    void Update()
    {
        if(Movementplayer.forward == true)
        {
            myrb.velocity = new Vector2(velx, vely);
            Destroy(gameObject, 3f);
        }
        else if(Movementplayer.forward == false)
        {
            myrb.velocity = new Vector2(velxleft, vely);
            Destroy(gameObject, 3f);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag=="Enemy")
        {
            sounds.Playsound("playerhit");
            Destroy(collision.gameObject); 
        }
    }
}

