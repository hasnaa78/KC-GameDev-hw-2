using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player2 : MonoBehaviour
{
    Rigidbody2D RB;

    float playerinput;

    public int speed;

    // Start is called before the first frame update
    void Start()
    {
        RB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        playerinput = Input.GetAxis("Vertical");
        RB.velocity = new Vector2(playerinput * speed, 0f);
    }
}