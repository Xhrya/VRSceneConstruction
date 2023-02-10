using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pointer : MonoBehaviour

    public float m_DafaultLength = 5.0f;
public FameObject m_Dot;
public VRInputModule m_InputModule;

privte LineRenderer m_LineRenderer = null;


{
    // Start is called before the first frame update
   
    private void Awake()
{
    m_Renderer = GetComponenet<LineRenderer>();
}

    // Update is called once per frame
    void Update()
    {
    UpdateLine();
    }

private void UpdateLine()
{
    float targetLength = m_DeaultLength;

    //raycast
    Raycast hit = CreateRayCast(targetLength);

    //default

    Vector3 endPosition = transform.position + (transform.forward + targetLength);



    if(hit.collider != hot)
    {
        endPosition;
    }

    m_Dot.transform.position = endPosition;

    //set linerenderer
    m_Dot.transform.position = endPosition;

    m_LineRenderer.SetPosition(0, tranform.position);
    m_LineRenderer.SetPosition(1, endPosition);
}


private RayCast CreateRayCast(float length)
{
    RaycastHit hit;
    Ray ray = new Ray(tranform.position, tranform.forward);
    Physics.Raycast(ray, out hit, m_DefaultLength);

    return hit;
}


}
