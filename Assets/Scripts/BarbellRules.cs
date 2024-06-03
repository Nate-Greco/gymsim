using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.XR;
using UnityEngine.UIElements;
using UnityEngine.XR.Interaction.Toolkit;
using static UnityEngine.SpatialTracking.TrackedPoseDriver;

public class BenchRules : MonoBehaviour
{
    public GameObject head;
    public GameObject body;
    public GameObject theoreticalHeadPosition;
    public GameObject barbell;
    public GameObject socket;
    public GameObject handR;
    public GameObject handL;
    //public TrackedPoseDriver trackePose;
    private TrackedPoseDriver.TrackingType m_trackingType;
    private UnityEngine.Transform newHeadPosition;
    private UnityEngine.Transform ogPos;
    private bool benching = false;
    private bool barInSlot;
    private bool afterInit = false;
    void Start()
    {
        //newHeadPosition = theoreticalHeadPosition.transform;
        ogPos = body.transform;
        barInSlot = socket.GetComponent<XRSocketInteractor>().hasSelection;
        UnityEngine.Debug.Log(barInSlot);
        
    }
    void Update()
    {
        UnityEngine.Debug.Log(afterInit);
        if (afterInit)
        {
            UnityEngine.Debug.Log("Bar slotted");
            // deadzones for barbell
            barInSlot = socket.GetComponent<XRSocketInteractor>().hasSelection;
            UnityEngine.Debug.Log(barInSlot);
            // check if barbell is on rack or not
            if (!barInSlot && (!benching))
            {
                benching = true;
            }
            else if (barInSlot && (benching))
            {
                benching = false;
            }

            // if barbell is off, run vibrations
            if (benching)
            {

                if (!(handL.transform.position.y <= handR.transform.position.y + 0.08f && handL.transform.position.y >= handR.transform.position.y - 0.08f))
                {
                    handL.GetComponent<VibrateController>().ActivateHaptic(1.0f, Time.deltaTime);
                    handR.GetComponent<VibrateController>().ActivateHaptic(1.0f, Time.deltaTime);
                }
                else
                {
                    if (!(handL.transform.position.z <= head.transform.position.z - 0.09f && handL.transform.position.z >= head.transform.position.z - 0.25f))
                    {
                        handL.GetComponent<VibrateController>().ActivateHaptic(1.0f, Time.deltaTime);
                    }
                    else
                    {
                        handL.GetComponent<VibrateController>().ActivateHaptic(0.0f, Time.deltaTime);
                    }
                    if (!(handR.transform.position.z <= head.transform.position.z - 0.09f && handR.transform.position.z >= head.transform.position.z - 0.21f))
                    {
                        handR.GetComponent<VibrateController>().ActivateHaptic(1.0f, Time.deltaTime);
                    }
                    else
                    {
                        handR.GetComponent<VibrateController>().ActivateHaptic(0.0f, Time.deltaTime);
                    }
                }


            }
            else
            {
                handL.GetComponent<VibrateController>().ActivateHaptic(0.0f, Time.deltaTime);
                handR.GetComponent<VibrateController>().ActivateHaptic(0.0f, Time.deltaTime);
            }
        }
        else
        {
            UnityEngine.Debug.Log("Bar not slotted");
            barInSlot = socket.GetComponent<XRSocketInteractor>().hasSelection;
            if (barInSlot)
            {
                UnityEngine.Debug.Log("Bar now slotted");
                
                afterInit = true;
            }
        }
    }
}

