using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coinrotation : MonoBehaviour
{
    public float speed;
    public RepositionDelay rd;
    public int coinvalue;
    // Start is called before the first frame update
    void Start()
    {
        rd = FindObjectOfType<RepositionDelay>();
    }

    // Update is called once per frame
    void Update()
    {
        this.gameObject.transform.Rotate(Vector2.up * 2);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            rd.AddScore(coinvalue);
            Destroy(gameObject);
        }
    }
}
