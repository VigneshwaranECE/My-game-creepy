using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cameramovement : MonoBehaviour
{
    public GameObject player;
    private Vector3 playervalue;
    public float offset;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        playervalue = new Vector3(player.transform.position.x, transform.position.y, transform.position.z);
        if (player.transform.localScale.x > 0f)
        {
            playervalue = new Vector3(playervalue.x + offset, playervalue.y, playervalue.z);
        }
        else
        {
            playervalue = new Vector3(playervalue.x - offset, playervalue.y, playervalue.z);
        }
        transform.position = playervalue;
    }
}
