using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.XR;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit;

public class PlayerSpawnAtLocation : MonoBehaviour
{
    [SerializeField]
    TeleportationAnchor spawnLocation;

    private TeleportationProvider teleProvider;

    // Start is called before the first frame update
    void Start()
    {
        teleProvider = GetComponent<TeleportationProvider>();
        
        Debug.Log("We started");
        
       
        Invoke("SpawnProperly", 5f);
       // transform.localPosition = new Vector3(0,0,0);
    }
    void SpawnProperly(){
        var poseDriver = Camera.main.gameObject.GetComponent<TrackedPoseDriver>();
        poseDriver.trackingType = TrackedPoseDriver.TrackingType.RotationOnly;
        Camera.main.transform.localPosition = new Vector3(0,0,0);
        
        transform.SetPositionAndRotation(spawnLocation.transform.position, spawnLocation.transform.rotation);
        

        //transform.position = spawnLocation.position;
       // transform.localPosition = new Vector3(0,0,0);
        //Debug.Log("We should spawn properly");
         //transform.position = spawnLocation.position;
    }

    // Update is called once per frame
    void Update()
    {
//transform.localPosition = new Vector3(0,0,0);transform.localPosition = new Vector3(0,0,0);
    }
    void FixedUpdate(){
        
    }
}
