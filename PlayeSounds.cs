using UnityEngine;
using System.Collections;

public class PlayeSounds : MonoBehaviour {


    public AudioSource someSound;
   

        // Use this for initialization
        void Start () {


        
    }

    // Update is called once per frame
    void Update()
    {




        if (Input.GetKeyDown(KeyCode.UpArrow))
        {

            someSound.Play();

        }



    }

   


} 
