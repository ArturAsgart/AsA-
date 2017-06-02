using UnityEngine;
using System.Collections;

public class fireshot : MonoBehaviour {





    public float speed;
    public bool moveR;
    Rigidbody2D rb;

    public Transform wallCheck;
    public float wallCheckRadius;
    public LayerMask WhatIswall;
    public bool hittingwall;
   

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody2D>();


    }
	
	// Update is called once per frame
	void Update () {

       
        hittingwall = Physics2D.OverlapCircle(wallCheck.position, wallCheckRadius, WhatIswall);

        if (hittingwall)
        {
            GameObject.Find(gameObject.name + ("spawn point")).GetComponent<respoint>().Death = true;
            Destroy(gameObject);
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
