using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyVertical : MonoBehaviour
{
    public float speed;
    public Vector3 startpos;
    public Vector3 targetpos;
    public Vector3 settingpos;
    public GameObject enemy;

    // Start is called before the first frame update
    void Start()
    {
        startpos = enemy.transform.position;
        targetpos = new Vector3(enemy.transform.position.x, enemy.transform.position.y + 3, 0);
        settingpos = targetpos;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 poss = transform.position;
        if(poss!=targetpos)
        {
            transform.position = Vector3.MoveTowards(poss, targetpos, speed*Time.deltaTime);
        }
        else
        {
            targetpos = startpos;
            if(poss==startpos)
            {
                targetpos = settingpos;
            }
        }
        //transform.Translate(Vector2.up*speed*Time.deltaTime);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name=="Player")
        {
            collision.gameObject.SetActive(false);
        }
    }
}
