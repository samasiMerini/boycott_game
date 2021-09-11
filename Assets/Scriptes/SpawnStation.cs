using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnStation : MonoBehaviour {
    public GameObject [] cars;
    int carnbr;
    public static float delayTime = 2f;
    float timer;




	// Use this for initialization
	void Start () {
        timer = delayTime;
       
    }  
	
	// Update is called once per frame
	void Update () {
        timer -= Time.deltaTime;
        if(timer <= 0)
        {
            Vector3 carPos = new Vector3(Random.Range(-2.2f, 2.2f), transform.position.y, transform.position.z);
            carnbr = Random.Range(0, 4);
            Instantiate(cars[carnbr], carPos, transform.rotation);
            timer = delayTime;
        }
		
	}
    
}
