using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddel2Movement : MonoBehaviour
{
    [SerializeField]
    float paddelSpeed = 5;
    [SerializeField]
    float paddelLimit = 7;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow) && transform.position.y < paddelLimit)
        {
            transform.position += new Vector3(0, paddelSpeed, 0) * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.DownArrow) && transform.position.y > -paddelLimit)
        {
            transform.position += new Vector3(0, -paddelSpeed, 0) * Time.deltaTime;
        }
    }
}
