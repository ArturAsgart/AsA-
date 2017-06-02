using UnityEngine;
using System.Collections;

public class LvlManeger : MonoBehaviour {


    public GameObject currentCheckpoint;
   private PlayerManagerM sharlotte;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()

    {
        sharlotte = FindObjectOfType<PlayerManagerM>();





	}

    public void RespawnPlayer()
    {

        Debug.Log("Player Respawn");
        sharlotte.transform.position = currentCheckpoint.transform.position;
      

    }

}
