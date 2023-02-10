using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsPointer : MonoBehaviour
{
    //this was I can see exactly what I'm pointing at/touching
    //create another method so that I can leave a trace of everything I've touched(in that sense, drilled)


    //we use the Raycaster (graphic raycaster) to raycast against the screen; so we're going to be using it here to create  a ray to where it is touchin 

    public float defaultLength = 3.0f;

    private LineRenderer lineRenderer = null;
    // Start is called before the first frame update
    void Awake()
    {
        lineRenderer = GetComponent <LineRenderer()>
    }

    // Update is called once per frame
    void Update()
    {
        UpdateLength();}

    private void UpdateLength()
    {
        lineRenderer.SetPosition(0, transform.position);
        lineRenderer.SetPosition(1, CalcualteEnd());
    }

    private Vector3 CalcualteEnd()
    {

    }

    private RaycastHit CreateForwardRaycast()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit))
        {
            
        }
    }


    private Vector3 DefaultEnd(float length)
    {

    }




    
}
