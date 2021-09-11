using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {

	public float Speed = 10f;
    float MinX = -2.4f;
    float MaxX = 2.4f;

    private void Start()
    {
        Time.timeScale = 1f;
    }
    // Update is called once per frame
    void Update () {
        float h = Input.GetAxis("Horizontal");
        Vector2 currentPosition = transform.position;
        if (h > 0)
        {
            currentPosition.x += Speed * Time.deltaTime;
            transform.localScale = new Vector3(0.3f, 0.3f, 0.3f);

        }
        if (h < 0)
        {
            currentPosition.x -= Speed * Time.deltaTime;
            transform.localScale = new Vector3(-0.3f, 0.3f, 0.3f);
        }
        if (currentPosition.x > MaxX)
            currentPosition.x = MaxX;
        if (currentPosition.x < MinX)
            currentPosition.x = MinX;
        transform.position = currentPosition;
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Ifriquia")
        {
            Time.timeScale = 0;
            StartCoroutine(restartGame());
        }
    }
    IEnumerator restartGame()
    {
        yield return new WaitForSecondsRealtime(1.3f);
        SceneManager.LoadScene("GamePlay");
    }
}
