using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseCameraController : BaseElectronicController
{
    private void Start()
    {
        base.Start();
        SetRotation();
        
    }
    private void Update()
    {
    }
    public override void TakenControl()
    {
        GetComponent<Renderer>().enabled = false;
        
        SetCameraTransform();
    }

    public override void LostControl()
    {
        GetComponent<Renderer>().enabled = true;
    }

    private void SetCameraTransform()
    {
        Camera camera = Camera.main;
        camera.transform.position = this.transform.position;
        camera.transform.rotation = this.transform.rotation;
    }

    public override void MouseMovementX(float mouseX)
    {
 

       // Camera.main.transform.Rotate(0, mouseX, 0);
    }

    public override void MouseMovementY(float mouseY)
    {
     

        //Camera.main.transform.Rotate(-mouseY, 0, 0);
    }


    private void SetRotation()
    {
        Quaternion rotation = transform.rotation;
        rotation.x += 0.01f;
        transform.rotation = rotation;
    }
}
