using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed;
    public float distance;
    private bool moveright;
    public Transform platformdetect; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right*speed*Time.deltaTime);
        RaycastHit2D groundcheck = Physics2D.Raycast(platformdetect.position, Vector2.down, distance);
        if(groundcheck.collider==false)
        {
            if(moveright)
            {
                transform.eulerAngles = new Vector3(0, -180, 0);
                moveright = false;
            }
            else
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
                moveright = true;
            }
        }
    }
}
