using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Boll : MonoBehaviour
{
    TextMeshProUGUI scoreText;
    Vector3 dir;
    int player1Goal = 0;
    int player2Goal = 0;
    float speed = 8;

    // Start is called before the first frame update
    void Start()
    {
        scoreText = FindObjectOfType<TextMeshProUGUI>();
        ResetBall();

        int x = Random.Range(0, 2);
        if (x==0)
        {
            x = -1;
        }
        dir = new Vector3(x, Random.Range(-1, 2), 0);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            dir.x *= -1;
            speed *=  1.2f;
            if (speed > 15)
            {
                speed = 15;
            }
        }
        else
        {
            dir.y *= -1;
        }
    }
    // Update is called once per frame
    void Update()
    {
        scoreText.text = player1Goal + "-" + player2Goal;
        if (Input.GetKeyDown(KeyCode.R))
        {
            ResetBall();
        }
        transform.position += dir * speed * Time.deltaTime;
        if (transform.position.x > 17)
        {
            player1Goal += 1;
            ResetBall();
        }
        else if (transform.position.x < -17)
        {
            player2Goal += 1;
            ResetBall();
        }
    }
    private void ResetBall()
    {
        transform.position = new Vector3(0, 0, 0);
        int x = Random.Range(0, 2);
        if (x == 0)
        {
            x = -1;
        }
        dir = new Vector3(x, Random.Range(-1, 2), 0);
    }
}
