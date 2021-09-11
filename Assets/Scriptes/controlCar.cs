using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlCar : MonoBehaviour {

    public float carSpeed = 10f;
    Vector3 position;


	// Use this for initialization
	void Start () {
        position = transform.position;	
	}
	
	// Update is called once per frame
	void Update () {
        position.x += Input.GetAxis("Horizontal") * carSpeed * Time.deltaTime;
        transform.position = position;
	}
}
