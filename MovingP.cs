using UnityEngine;
using System.Collections;

public class MovingP : MonoBehaviour {


    public GameObject Platform;
    public float MoveSpeed;
    public Transform CurrentPoint;
    public Transform[] Point;
    public int pointSelection;

	// Use this for initialization
	void Start () {

        CurrentPoint = Point[pointSelection];
	
	}
	
	// Update is called once per frame
	void Update () {

        
        Platform.transform.position = Vector3.MoveTowards(Platform.transform.position, CurrentPoint.position, Time.deltaTime + MoveSpeed);
        if(Platform.transform.position == CurrentPoint.position)
        {

            pointSelection++;


            if (pointSelection == Point.Length)
            {

                pointSelection = 0;
            }
            CurrentPoint = Point[pointSelection];

        }
           
	
	}
}
