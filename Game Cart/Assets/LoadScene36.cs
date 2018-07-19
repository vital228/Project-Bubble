using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene36 : MonoBehaviour {
    public string nextScene;

    private void OnMouseDown() { SceneManager.LoadScene(nextScene); }


}
	