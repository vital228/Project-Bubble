using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cart : MonoBehaviour {
    bool onTouch = false;
    void OnMouseUp()
    {
        onTouch = !onTouch;
    }
    // Update is called once per frame
    void Update () {
       
        if (onTouch)
        {
            Vector3 worldPos = Input.mousePosition;
            worldPos = Camera.main.ScreenToWorldPoint(worldPos);
            this.transform.position = new Vector3(worldPos.x,worldPos.y,1);
        }
	}
}
