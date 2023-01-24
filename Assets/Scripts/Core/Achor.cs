using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// Data about the 
/// </summary>
[Serializable]
public class AnchorData
{
    /// <summary>
    /// The handle that represents the anchor in this runtime
    /// </summary>
    public ulong spaceHandle;

    /// <summary>
    /// The name of the prefab that should be instantiated for this anchor
    /// </summary>
    public string prefabName;

    /// <summary>
    /// Reference to the gameobject instantiated in scene for this anchor
    /// </summary>
    public GameObject instantiatedObject = null;
}

public class Achor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

/*//get the pose of the controller in local tracking coordinates
OVRPose controllerPose = new OVRPose()
{
    position = OVRInput.GetLocalControllerPosition(isLeft ? OVRInput.Controller.LTouch : OVRInput.Controller.RTouch),
    orientation = OVRInput.GetLocalControllerRotation(isLeft ? OVRInput.Controller.LTouch : OVRInput.Controller.RTouch)
};

//create the information about the spatial anchor (time and position), that should have the same pose of the controller.
//You can use the below template almost every time
OVRPlugin.SpatialEntityAnchorCreateInfo createInfo = new OVRPlugin.SpatialEntityAnchorCreateInfo()
{
    Time = OVRPlugin.GetTimeInSeconds(),
    BaseTracking = OVRPlugin.GetTrackingOriginType(),
    PoseInSpace = controllerPose.ToPosef() //notice that we take the pose in tracking coordinates and convert it from left handed to right handed reference system
};

//ask the runtime to create the spatial anchor. 
//The creation is instanteneous, and the identification handle is returned by the runtime inside the "ref" parameter
ulong spaceHandle = InvalidHandle;

if (OVRPlugin.SpatialEntityCreateSpatialAnchor(createInfo, ref spaceHandle))*/


