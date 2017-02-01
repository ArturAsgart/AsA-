using UnityEngine;
using System.Collections;

public class ArtifactPickUp : MonoBehaviour {

    public int pointsToAdd;

    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.GetComponent<PlayerManagerM>() == null)
            return;


        Artifacts.AddPoints(pointsToAdd);



        Destroy(gameObject);
    }








}
