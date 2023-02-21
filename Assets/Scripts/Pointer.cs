using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class Pointer : MonoBehaviour
{
    public float defaultlength = 5.0f;
    public GameObject dot;
    public VRInputModule inputModule;

    private LineRenderer lineRenderer = null;

        private void Awake()
    {
        lineRenderer = GetComponent<LineRenderer>();
    }

    private void Update()
    {
        UpdateLine();
    }

    private void UpdateLine()
    {   
        PointerEventData Data = inputModule.GetData();
        float targetLength = Data.pointerCurrentRaycast.distance == 0 ? defaultlength : Data.pointerCurrentRaycast.distance;
        RaycastHit hit = CreateRaycast(targetLength);

        Vector3 endPosition = transform.position + (transform.forward * targetLength);

        if(hit.collider != null)
            endPosition = hit.point;

        dot.transform.position = endPosition;

        lineRenderer.SetPosition(0, transform.position);
        lineRenderer.SetPosition(1, endPosition);
        
        
    }
    
    private RaycastHit CreateRaycast(float length)
    {
        RaycastHit hit;
        Ray ray = new Ray(transform.position, transform.forward);

        Physics.Raycast(ray, out hit, defaultlength);
        return hit;
        
    }
    
    

}
