using UnityEngine;
using System.Collections;

public class destroySkill : MonoBehaviour
{
    public float delay;

	// Use this for initialization
	void Start ()
    {
        // Destroy gameObjeck  
        Destroy(gameObject, delay);
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}
}
