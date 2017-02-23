using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayerDeath : MonoBehaviour {

    public string sceneName;

    public SurviveTimer timerScript;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnDestroy()
    {
        PlayerPrefs.SetInt("Score", (int)timerScript.time);
        SceneManager.LoadScene(sceneName);
    }
}
