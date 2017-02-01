using UnityEngine;
using System.Collections;
//  Skills Options
public class skillOne : MonoBehaviour
{
    public Vector2 speed;
    Rigidbody2D rb;
	// Use this for initialization
	void Start ()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = speed;




	}
	
	// Update is called once per frame
	void Update ()
    {




        // skill speed
        rb.velocity = speed;

    }
    // kill gameObjeck with tag will  be Destroyed
     void OnCollisionEnter2D(Collision2D other)
      {





        if (other.gameObject.CompareTag ("enemy"))
         {

             Destroy(other.gameObject);
             Destroy(gameObject);

        }

       
    }

    



}
