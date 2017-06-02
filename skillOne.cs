using UnityEngine;
using System.Collections;
//  Skills Options
public class skillOne : MonoBehaviour
{
    public Vector2 speed;
    Rigidbody2D rb;
    public int dodmg;
    public enemyHP enemyhp;
   
	// Use this for initialization
	void Start ()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = speed;
     //   enemyhp = GetComponent<enemyHP>();
        //enhp = GetComponent<enemyHP>();
        

	}
	
	// Update is called once per frame
	void Update ()
    {




        // skill speed
        rb.velocity = speed;

    }
    // kill gameObjeck with collider trigger 
     void OnTriggerEnter2D (Collider2D other)
      {
        


       // do dmg and killskill 
        if (other.gameObject.CompareTag ("enemy"))
         {
           
            Debug.Log("lol");
            other.SendMessageUpwards("takeeDMG", dodmg);
            Destroy(gameObject);
           
           
        }
        

       
    }

    



}
