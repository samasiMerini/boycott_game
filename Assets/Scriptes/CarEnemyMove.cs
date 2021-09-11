using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarEnemyMove : MonoBehaviour {
    public static float speed=2f;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(CollectBomb.score <= 5)
        {
            transform.Translate(new Vector3(0, -1, 0) * speed * Time.deltaTime);

        }
        else if (CollectBomb.score > 5 && CollectBomb.score <=10)
        {
            //GetComponent<TrackMove>().speedTrack = 2f;
            TrackMove.speedTrack = 1.5f;
            speed = 3f;
            transform.Translate(new Vector3(0, -1, 0) * speed * Time.deltaTime);

        }
        else if(CollectBomb.score > 10 && CollectBomb.score < 20)
        {
            //GetComponent<TrackMove>().speedTrack = 2f;
            TrackMove.speedTrack = 1.5f;
            speed = 4f;
            SpawnStation.delayTime = 1f;
            transform.Translate(new Vector3(0, -1, 0) * speed * Time.deltaTime);

        }
        else if (CollectBomb.score > 20 && CollectBomb.score <= 35)
        {
            TrackMove.speedTrack = 2f;
            speed = 6f;
            transform.Translate(new Vector3(0, -1, 0) * speed * Time.deltaTime);

        }
    }
}
