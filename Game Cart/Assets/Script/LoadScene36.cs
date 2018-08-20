using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScrpt : MonoBehaviour {

	// Use this for initialization
	
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnMouseDown()
    {
        SceneManager.LoadScene(sceneName: "36");
    }
}
