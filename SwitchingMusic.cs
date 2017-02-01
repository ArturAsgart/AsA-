using UnityEngine;
using System.Collections;

public class SwitchingMusic : MonoBehaviour {


    public AudioClip newTrack;

    private AudioManeger theAM;
	// Use this for initialization
	void Start ()
    {
        theAM = FindObjectOfType<AudioManeger>();


	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.name == "sharlotte")
        {
            if (newTrack != null)
                theAM.ChangeBGM(newTrack);

        }

    }


}
