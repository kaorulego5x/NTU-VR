using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonolithVerticalMove : MonoBehaviour
{
    public float speed;
    public float delaySecond;
    private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position;
    }

    // Update is called once per frame
    void Update()
    {  
        transform.position = new Vector3(0, 20f * Mathf.Sin(speed * Time.time + delaySecond) , 0) + offset;
    }
}
