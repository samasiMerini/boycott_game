using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LikePiano : MonoBehaviour {
    public GameObject [] cars;
    int carnbr;
    public float delayTime = 1f;
    float timer;
    public Text scoretxt;
    public static int scoreclick = 0;
    public GameObject gameover;
    public bool isplay;


    private void Awake()
    {
        isplay = true;
    }

    // Use this for initialization
    void Start () {
        Time.timeScale = 1;
        timer = delayTime;
        scoretxt.text = "Score : " + scoreclick;
        scoreclick = 0;

       
    }  
	
    public void GameOverMenu()
    {
        isplay = false;
    }

	// Update is called once per frame
	void Update () {
        
            
       
            timer -= Time.deltaTime;
            if (timer <= 0)
            {
                Vector3 carPos = new Vector3(transform.position.x, transform.position.y, transform.position.z);
                carnbr = Random.Range(0, 8);
                Instantiate(cars[carnbr], carPos, transform.rotation);
                timer = delayTime;
                scoretxt.text = "Score : " + scoreclick;
            
            
        
        }
		
	}
    
}
