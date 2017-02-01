using UnityEngine;
using System.Collections;

public class skill2 : MonoBehaviour
{

    public Vector2 speed;
    Rigidbody2D rb;
    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = speed;
    }

    // Update is called once per frame
    void Update()
    {
        // skill speed
        rb.velocity = speed;

    }
    // kill gameObjeck if tag is one shot
   void OnCollisionEnter2D(Collision2D other)
    {

        if (other.gameObject.CompareTag( "oneshot") || other.gameObject.CompareTag ( "enemy" ))
        {

            Destroy(other.gameObject);
            Destroy(gameObject);

        }

    }
    
}