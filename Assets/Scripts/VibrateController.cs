using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;


public class VibrateController : MonoBehaviour
{
    [SerializeField]
    private ActionBasedController Controller;
    [Range(0, 1)]
    public float intensity;
    public float duration;
    void Awake()
    {
        Controller = GetComponent<ActionBasedController>();
    } 
    public void ActivateHaptic(float amplitude, float duration)
    {
        if (Controller != null) 
        {
            Controller.SendHapticImpulse(amplitude, duration);
        }
        Debug.Log("Haptics should be working");
    }

}