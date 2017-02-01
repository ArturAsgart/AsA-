using UnityEngine;
using System.Collections;

public class AudioManeger : MonoBehaviour
{


    public AudioSource BGM;



   





        // Use this for initialization
        void Start ()
    {




       // DontDestroyOnLoad(gameObject);
	}

    
	
	// Update is called once per frame
	void Update () {
	
	}

    public void ChangeBGM(AudioClip music)
    {

        if (BGM.clip.name == music.name)
            return;

        BGM.Stop();
        BGM.clip = music;
        BGM.Play();

    }


}
