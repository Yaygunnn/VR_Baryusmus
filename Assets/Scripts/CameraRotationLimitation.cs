using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class CameraRotationLimitation : MonoBehaviour
{
    private float Limit = 30;
    private Camera cam;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        LimitCameraRotation();
    }

    private void LimitCameraRotation()
    {
        cam = GameModel.Instance.camera;
       

        Vector3 rot = cam.transform.eulerAngles;

       rot.x=Mathf.Clamp(rot.x, Limit, -Limit);

        rot.y = Mathf.Clamp(rot.y, Limit, -Limit);

        rot.z = Mathf.Clamp(rot.z, Limit, -Limit);

        cam.transform.eulerAngles = rot;

    }
}
