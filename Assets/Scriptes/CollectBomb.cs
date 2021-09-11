using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CollectBomb : MonoBehaviour {
   public Text scroretext;
    public static int score= 0;
    public GameObject ifriquiaLogo;


    private void Start()
    {
        score = 0;
        Time.timeScale = 1;
        scroretext.text = "score : " + score;
    }
    public void scoret()
    {
        score++;
        scroretext.text = "score : " + score;
        

}
    public void replayBtn()
    {
       
        SceneManager.LoadScene("test");
    }

private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Station")
        {
            collision.gameObject.SetActive(false);
            scoret();
                    }
        if(collision.tag == "Ifriquia")
        {
            collision.gameObject.SetActive(false);

            Time.timeScale = 0;
            ifriquiaLogo.SetActive(true);
        }

    }
    
}
