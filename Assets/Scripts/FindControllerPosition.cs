using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindControllerPosition: MonoBehaviour
{

    public GameObject head;
    public GameObject handR;
    public GameObject handL;
    private Vector3 headPosition;
    private Vector3 handRPosition;
    private Vector3 handLPosition;
    // Update is called once per frame
    void Update()
    {
        headPosition = head.transform.position;
        handRPosition = handR.transform.position;
        handLPosition = handL.transform.position;
        //handL.GetComponent<VibrateController>().ActivateHaptic(handLPosition.y, Time.deltaTime);
        //handR.GetComponent<VibrateController>().ActivateHaptic(handRPosition.y, Time.deltaTime);
    }
    public Vector3 findheadPosition() {  return headPosition; }
    public Vector3 findhandRPosition() {  return handRPosition; }
    public Vector3 findhandLPosition() {  return handLPosition; }
}
