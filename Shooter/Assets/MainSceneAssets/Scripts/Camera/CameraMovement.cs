using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour
{

    GameObject player;

    // Use this for initialization
    void Start()
    {
        //gets the player object
        player = GameObject.FindGameObjectWithTag("Player");

    }

    // Update is called once per frame
    void Update()
    {
        //moves camera
        this.transform.position += new Vector3(0, 0.02f, 0);

        //prevents player from going off bottom of screen
        if (player.transform.position.y <= (this.transform.position.y - 5))
        {

            player.transform.position = new Vector3(player.transform.position.x, (this.transform.position.y - 5), 0);

        }
    }

}