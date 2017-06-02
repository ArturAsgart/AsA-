using UnityEngine;
using System.Collections;

public class KILLpatrol : MonoBehaviour
{

    public float speed;
    public bool moveR;
    Rigidbody2D rb;

    public Transform wallCheck;
    public float wallCheckRadius;
    public LayerMask WhatIswall;
    public bool hittingwall;




    void Start()



    {
        rb = GetComponent<Rigidbody2D>();

    }
    void Update()
    {
        hittingwall = Physics2D.OverlapCircle(wallCheck.position, wallCheckRadius, WhatIswall);

        if (hittingwall)
        {
            moveR = !moveR;
        }

        if (moveR)
        {
            transform.localScale = new Vector3(-1f, 1f, 1f);
            rb.velocity = new Vector2(speed, rb.velocity.y);
        }
        else
        {
            transform.localScale = new Vector3(1f, 1f, 1f);
            rb.velocity = new Vector2(-speed, rb.velocity.y);

        }
       


    }
}