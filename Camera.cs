using UnityEngine;
using System.Collections;

public class Camera : MonoBehaviour {



    public PlayerManagerM sharlotte;
    public bool isFallowing;
    public float xOffset;
    public float yOffseet;
	// Use this for initialization
	void Start () {

        sharlotte = FindObjectOfType<PlayerManagerM>();
        isFallowing = true;
	
	}
	
	// Update is called once per frame
	void Update () {


        if (isFallowing)
            transform.position = new Vector3(sharlotte.transform.position.x + xOffset, sharlotte.transform.position.y + yOffseet, transform.position.z);
	
	}
}
