using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SurviveTimer : MonoBehaviour {

    public float time;
    public Text text;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        time += Time.deltaTime;
        text.text = "You survive: " + (int)time + " sec";
	}
}
