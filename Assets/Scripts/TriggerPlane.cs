using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerPlane : MonoBehaviour
{

    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter() {
        Debug.Log("entered!");
        animator.Play("Base Layer.StandUpAnimation");
    }
}
