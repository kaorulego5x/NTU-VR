using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monolith_move : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {  
        transform.Translate(0.2f * Mathf.Sin(speed * Time.time * Mathf.PI * 2f), 0, 0); 
    }
}
