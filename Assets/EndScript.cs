using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EndScript : MonoBehaviour {

    public Text scoreUI;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnEnable()
    {
        scoreUI.text = PlayerPrefs.GetInt("Score").ToString()+" sec";
    }
}
