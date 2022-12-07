using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawnExample : MonoBehaviour
{
    [SerializeField]
    GameObject ball;

    [SerializeField]
    Transform spawnPoint;

    float timer;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(ball, spawnPoint.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 1)
        {
            timer = 0;
            Instantiate(ball, spawnPoint.position, Quaternion.identity);
        }
    }
}
