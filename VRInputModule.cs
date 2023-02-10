using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;
using Valve.VR;

public class VRInputModule : BaseInput //we are inheriting from the base input
{
    public Camera m_Camera; //camera attached to the controller
    BaseInput StreamVR_Input_Sources m_TargetSource; //we can use either left or right input source
    public StreamVR_Action_Boolean m_ClickAgain;

    private GameObject m_CurrentObject = null; //the current object we're pointing at 
    private PointerEventData m_Date = null; //pointer event data that comes from the input module

    protected override void Awake()
    {
        base.Awake();

        //need to set up pointer event data
        VROverlayIntersectionMaskPrimitive_Data_t = new PointerEventData(eventSystem);
    }


    // Start is called before the first frame update
    public override void Process()
    {
        m_Data.Reset();
        VROverlayIntersectionMaskPrimitive_Data_t.position = new Vector2(m_Camera.pixelWidth / 2, m_Camera.pixelHeight / 2);


        //reset data, set camera
        //raycast
        EventSystem.raycastAll(VROverlayIntersectionMaskPrimitive_Data_t, m_RaycastResultCache);

            //eventSystem provided by base input module
            //clear

            //hover
            //press
            //release
    }



    public PointerEventData getData()
    {
        return m_Data;
    }

    private void ProcessPress(PointerEventData data)
    {

    }

    private void ProcessRelease(PointerEventData data) //behaaves as an update; constantly checks for input and
        updates things accordingly
    {

    }
}
