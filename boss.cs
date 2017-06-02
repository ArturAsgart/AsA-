using UnityEngine;
using System.Collections;

public class boss : MonoBehaviour {
    Rigidbody2D rb;
    
    
    // Use this for initialization
    void Start () {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (rb.position.x < 0) {
            Vector3 temp = transform.localScale;
            temp.x *= -1;

        }
       if(rb.position.x > 0f)
        {
            Vector3 temp = transform.localScale;
            temp.x *= 1;

        }
       }
    }
