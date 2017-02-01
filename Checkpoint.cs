using UnityEngine;
using System.Collections;

public class Checkpoint : MonoBehaviour {

    public LvlManeger lvlManeger;
    

    // Use this for initialization
    void Start()

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
            lvlManeger.currentCheckpoint = gameObject;
            
            Debug.Log("Activated Checkpoint" + transform.position);
        }


    }

}
