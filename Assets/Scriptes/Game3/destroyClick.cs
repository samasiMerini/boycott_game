using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class destroyClick : MonoBehaviour {

    float speed = 5f;

    

    private void OnMouseDown()
    {
        if(gameObject.tag != "Central")
        {
            LikePiano.scoreclick++;
            Destroy(gameObject);
        }
        else
        {

           // GetComponent<LikePiano>().GameOverMenu();
            Time.timeScale = 0;
            Destroy(gameObject);
        }
      
    }
    void Update()
    {
        if (LikePiano.scoreclick <= 10)
        {
            transform.Translate(new Vector3(0, -1, 0) * speed * Time.deltaTime);

        }
        else if (LikePiano.scoreclick > 10 && LikePiano.scoreclick <=25)
        {
           speed = 9f;
            transform.Translate(new Vector3(0, -1, 0) * speed * Time.deltaTime);

        }
        else if (LikePiano.scoreclick > 25 )
        {
            speed = 13f;
            transform.Translate(new Vector3(0, -1, 0) * speed * Time.deltaTime);
        }
    }

}
