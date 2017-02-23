using UnityEngine;
using System.Collections;

public class Difficult : MonoBehaviour {

    public Laser laserScript1;
    public Laser laserScript2;
    public SurviveTimer timerScript;

    public GameObject laserObj2;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if(timerScript.time > 5f)
        {
            laserScript1.moveSpeed = 9;
            laserScript2.moveSpeed = 9;
        }
        if (timerScript.time > 10f)
        {
            laserScript1.moveSpeed = 13;
            laserScript2.moveSpeed = 13;
        }
        if (timerScript.time > 15f)
        {
            laserScript1.moveSpeed = 17;
            laserScript2.moveSpeed = 17;
        }

        if (timerScript.time > 20f)
        {
            laserObj2.SetActive(true);
        }
	}

    /*
     * 1) 1 лазер увиличивает скорость с одной стороны
     * 2) 2 лазера с 1 стороны
     * 3) 2 лазера с 2 сторон
     */
}
