using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLocationSeter : MonoBehaviour
{
    public static GameObject Player;
    public static Camera Camera;

    static private GameObject TargetCameraTransform;
    void Update()
    {
        SetPlayerLocationAccordingToCameraLocation(); 
    }

    static private void SetPlayerLocationAccordingToCameraLocation()
    {
        if(TargetCameraTransform != null)
        {
            Player.transform.position = TargetCameraTransform.transform.position - Camera.transform.localPosition;
        }
    }
  
    static public void SetNewCameraTransformObject(GameObject newTransform)
    {
        TargetCameraTransform = newTransform;
        Player.transform.rotation=newTransform.transform.rotation;
        SetPlayerLocationAccordingToCameraLocation();
    }



}
