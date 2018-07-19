using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Game : MonoBehaviour {
    public Cart[] cart = new Cart[36];
    public void CartNavigator(Cart cart1, int n)
    {
        switch (n)
        {

            case 1:
                Instantiate(cart1, new Vector3(x: -3, y: -3, z: 0), new Quaternion(0, 0, 0, 0));
                //cart1.transform.position = new Vector3(x: -3, y: -3, z: 0);
               // cart1.transform.rotation = new Quaternion(45, 1, -20, 0);
                break;
            case 2:
                Instantiate(cart1, new Vector3(x: -1.5f, y: -3, z: 1), new Quaternion(0, 0, 0, 0));
               // cart1.transform.position = new Vector3(x: -1.5f, y: -3, z: 0);
                //cart1.transform.rotation = new Quaternion(45, 1, -10, 0);
                break;
            case 3:
                Instantiate(cart1, new Vector3(x: -0.5f, y: -3, z: 2), new Quaternion(0, 0, 0, 0));
                //cart1.transform.position = new Vector3(x: -0.5f, y: -3, z: 0);
                //cart1.transform.rotation = new Quaternion(45, 1, -5, 0);
                break;
            case 4:
                Instantiate(cart1, new Vector3(x: 0.5f, y: -3, z: 2), new Quaternion(0, 0, 0, 0));
                //cart1.transform.position = new Vector3(x: 0.5f, y: -3, z: 0);
                //cart1.transform.rotation = new Quaternion(45, 1, 5, 0);
                break;
            case 5:
                Instantiate(cart1, new Vector3(x: 1.5f, y: -3, z: 1), new Quaternion(0, 0, 0, 0));
                //cart1.transform.position = new Vector3(x: 1.5f, y: -3, z: 0);
               //cart1.transform.rotation = new Quaternion(45, 1, 10, 0);
                break;
            case 6:
                Instantiate(cart1, new Vector3(x: 3, y: -3, z: 0), new Quaternion(0, 0, 0, 0));
                //cart1.transform.position = new Vector3(x: 3, y: -3, z: 0);
                //cart1.transform.rotation = new Quaternion(45, 1, 20, 0);
                break;
        }
    }
    void Start () {
        for (int i = 1; i < 7; i++)
        {
            int value = Random.Range(0, 36);
            CartNavigator(cart[value], i);
        }
        
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
