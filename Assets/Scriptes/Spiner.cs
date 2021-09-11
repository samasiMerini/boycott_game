using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spiner : MonoBehaviour {
    public GameObject[] station ;
   // public GameObject bomb;
    public Transform stationPos;
    int randomInt;
    float MinX = -2.4f;
    float MaxX = 2.4f;

    // Use this for initialization
    void Start () {
        StartCoroutine(SpawnBomb());
	}
	
	IEnumerator SpawnBomb()
    {
        yield return new WaitForSeconds(Random.Range(0f, 1f));
        randomInt = Random.Range(0, station.Length);
     //   Instantiate(station[randomInt],stationPos.position,stationPos.rotation);

        Instantiate(station[randomInt], new Vector2(Random.Range(MinX, MaxX), transform.position.y), Quaternion.identity);
        //for(int i = 0; i < station.Length; i++)
        //{
        //  GameObject  station = (GameObject)Instantiate(bomb, new Vector2(Random.Range(MinX, MaxX), transform.position.y), Quaternion.identity);
        //}
       
        StartCoroutine(SpawnBomb());
    }

    void spownFunction()
    {

    }
}
