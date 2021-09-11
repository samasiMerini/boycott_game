using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackMove : MonoBehaviour {

    public static float speedTrack;
    Vector2 offset;


	// Use this for initialization
	void Start () {

        speedTrack = 1f;
		
	}
	
	// Update is called once per frame
	void Update () {
        offset = new Vector2(0, Time.time * speedTrack);
        GetComponent<Renderer>().material.mainTextureOffset = offset;

    }
}
