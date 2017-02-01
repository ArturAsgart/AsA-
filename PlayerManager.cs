using UnityEngine;
using System.Collections;

public class PlayerManager : MonoBehaviour
{
    Animator sharlotte;
	// Use this for initialization
	void Start ()
    {
        sharlotte = GetComponent<Animator>();
        
	}
	
	// Update is called once per frame
	void Update ()
    {
        // Handling the walking and Jump in  right side!!!!!!!!!!!!!!!!!!!!!! PC V1
        // D walk
        if (Input.GetKeyDown (KeyCode.D) )
        {

            sharlotte.SetInteger("state", 1);

        }


        if (Input.GetKeyUp(KeyCode.D))
        {

            sharlotte.SetInteger("state", 0);

        }
        // W jump

        if (Input.GetKeyDown(KeyCode.W))
        {

            sharlotte.SetInteger("state", 2);

        }

        if (Input.GetKeyUp(KeyCode.W))
        {

            sharlotte.SetInteger("state", 0);

        }
        // Handling the walking and Jump in  left side!!!!!!!!!!!!!!!!!!!!!!    PC V1
        // A walk
        if (Input.GetKeyDown(KeyCode.A))
        {

            sharlotte.SetInteger("state", 4);

        }

        if (Input.GetKeyUp(KeyCode.A))
        {

            sharlotte.SetInteger("state", 0);
        }

        //  jump

        if (Input.GetKeyDown(KeyCode.Q))
        {

            sharlotte.SetInteger("state", 5);

        }

        if (Input.GetKeyUp(KeyCode.Q))
        {

            sharlotte.SetInteger("state", 0);
        }

    }

}
