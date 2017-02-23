using UnityEngine;
using System.Collections;

public class Laser : MonoBehaviour {

    public Transform laserBeam;
    public float moveSpeed;
    private Transform currentPoint;
    public Transform[] points;
    private int pointSelection;
    public bool parentCollideObj;

	// Use this for initialization
	void Start () {
        currentPoint = points[pointSelection];
	}
	
	// Update is called once per frame
	void Update () {


        laserBeam.position = Vector3.MoveTowards(laserBeam.position, currentPoint.position, Time.deltaTime * moveSpeed);
        
        //смена точки в которую движемся
        if (laserBeam.transform.position == currentPoint.position)
        {
            pointSelection++;
            if (pointSelection == points.Length)
            {
                pointSelection = 0;
            }
            currentPoint = points[pointSelection];
        }
	}
}
