using UnityEngine;
using System.Collections;

public class Pausee : MonoBehaviour
{
    bool paused = false;
    public GameObject PauseUI;
    public float win;

    void Staart()
    {

        PauseUI.SetActive(false);

    }



    void Update()
    {


        // keyboard X -_-
        if (Input.GetKeyDown(KeyCode.X))
           paused = togglePause();


    }

  
    
    bool togglePause()
    {
        if (Time.timeScale == 0f)

        {
            // UNPAUSE!!!
            Time.timeScale = 1f;
            PauseUI.SetActive(false);
            return (false);
        }
        else
        {
            // PAUSE!!!
            Time.timeScale = 0f;
            PauseUI.SetActive(true);
            return (true);
        }
    }
    

    // mobile UI>>>>>>>>> BUTTON MENU!<<<<<<<<<<<<<<<
    public void pause1()
    {

        togglePause();
    }


    
}

    































    
    
    
    
    
    
    




    