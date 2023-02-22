using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HammerSwing : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    public float delaySecond;
    private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {  
        transform.rotation = Quaternion.Euler(0f, 0f, 45f * Mathf.Sin(speed * Time.time + delaySecond));
    }
}
