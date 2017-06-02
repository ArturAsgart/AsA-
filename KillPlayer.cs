using UnityEngine;
using System.Collections;

public class KillPlayer : MonoBehaviour {


    public LvlManeger lvlManeger;
    
   
    // Use this for initialization
    void Start ()

    {
        lvlManeger = FindObjectOfType<LvlManeger>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

   
    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.name == "sharlotte")
        {

            lvlManeger.RespawnPlayer();
        }
        if (other.gameObject.CompareTag("littlebullet"))
                {
            Destroy(other.gameObject);
            Destroy(gameObject);

           }

    }


}
